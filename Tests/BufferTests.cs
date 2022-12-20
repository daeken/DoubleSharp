using System.Runtime.CompilerServices;
using DoubleSharp.Buffers;
using DoubleSharp.Linq;

namespace Tests; 

[TestFixture]
public class BufferTests {
	[Test]
	public void HexDump() {
		Assert.Multiple(() => {
			Assert.That(new byte[] { 0, 1 }.ToHexDump(), Is.EqualTo("0000 | 00 01                                            | ..\n0002\n"));
			Assert.That(128.Times(i => (byte) i).ToArray().ToHexDump().Trim(), Is.EqualTo("""
0000 | 00 01 02 03 04 05 06 07  08 09 0A 0B 0C 0D 0E 0F | ........ ........
0010 | 10 11 12 13 14 15 16 17  18 19 1A 1B 1C 1D 1E 1F | ........ ........
0020 | 20 21 22 23 24 25 26 27  28 29 2A 2B 2C 2D 2E 2F | .!"#$%&' ()*.,-./
0030 | 30 31 32 33 34 35 36 37  38 39 3A 3B 3C 3D 3E 3F | 01234567 89:;<=>?
0040 | 40 41 42 43 44 45 46 47  48 49 4A 4B 4C 4D 4E 4F | @ABCDEFG HIJKLMNO
0050 | 50 51 52 53 54 55 56 57  58 59 5A 5B 5C 5D 5E 5F | PQRSTUVW XYZ[\]^_
0060 | 60 61 62 63 64 65 66 67  68 69 6A 6B 6C 6D 6E 6F | `abcdefg hijklmno
0070 | 70 71 72 73 74 75 76 77  78 79 7A 7B 7C 7D 7E 7F | pqrstuvw xyz{|}~.
0080
""".Trim()));
			Assert.That((0x40, 0x53).Range().Select(i => (byte) i).ToArray().ToHexDump().Trim(), Is.EqualTo("""
0000 | 40 41 42 43 44 45 46 47  48 49 4A 4B 4C 4D 4E 4F | @ABCDEFG HIJKLMNO
0010 | 50 51 52                                         | PQR
0013
""".Trim()));

			Assert.That(new[] { 0xDEADBEEFU, 0xCAFEBABEU }.ToHexDump(),
				BitConverter.IsLittleEndian
					? Is.EqualTo("0000 | EF BE AD DE BE BA FE CA                          | ........ \n0008")
					: Is.EqualTo("0000 | DE AD BE EF CA FE BA BE                          | ........ \n0008"));

			var sw = new StringWriter();
			new[] { 0xDEADBEEFU, 0xCAFEBABEU }.HexDump(sw);
			var temp = sw.ToString().TrimEnd();
			Assert.That(temp,
				BitConverter.IsLittleEndian
					? Is.EqualTo("0000 | EF BE AD DE BE BA FE CA                          | ........ \n0008")
					: Is.EqualTo("0000 | DE AD BE EF CA FE BA BE                          | ........ \n0008"));
		});
	}

	[Test]
	public void MemoryCasts() {
		Assert.Multiple(() => {
			var deadbeef = BitConverter.IsLittleEndian
				? 0xDEADBEEFU
				: 0xEFBEADDEU;
			var cafebabe = BitConverter.IsLittleEndian
				? 0xCAFEBABEU
				: 0xBEBAFECAU;
			var bmem = new Memory<byte>(new byte[] { 0xEF, 0xBE, 0xAD, 0xDE, 0xBE,0xBA, 0xFE, 0xCA });
			var umem = new Memory<uint>(new[] { deadbeef, cafebabe });
			
			Assert.That(bmem.Cast<byte, uint>().ToArray(), Is.EqualTo(umem.ToArray()));
			Assert.That(umem.Cast<uint, byte>().ToArray(), Is.EqualTo(bmem.ToArray()));
			
			Assert.That(bmem.Cast<byte, byte>().ToArray(), Is.EqualTo(bmem.ToArray()));
			Assert.That(umem.Cast<uint, uint>().ToArray(), Is.EqualTo(umem.ToArray()));
		});
	}

	[Test]
	public void AsEnumerable() {
		Assert.Multiple(() => {
			Assert.That(new byte[] { 1, 2, 3, 4 }.AsSpan().AsEnumerable(), Is.EqualTo(new byte[] { 1, 2, 3, 4 }));
			Assert.That(new[] { 1, 2, 3, 4 }.AsSpan().AsEnumerable(), Is.EqualTo(new[] { 1, 2, 3, 4 }));
			Assert.That(new byte[] { 1, 2, 3, 4 }.AsMemory().AsEnumerable(), Is.EqualTo(new byte[] { 1, 2, 3, 4 }));
			Assert.That(new[] { 1, 2, 3, 4 }.AsMemory().AsEnumerable(), Is.EqualTo(new[] { 1, 2, 3, 4 }));
		});
	}

	[Test]
	public unsafe void Map() {
		Assert.Multiple(() => {
			var span = 100000.Times(i => i).ToArray().AsSpan();
			var mapped = span.Map(x => x * 5);
			Assert.That((nint) Unsafe.AsPointer(ref mapped[0]), Is.EqualTo((nint) Unsafe.AsPointer(ref span[0])));
			Assert.That(span.AsEnumerable(), Is.EqualTo(100000.Times(i => i * 5)));
			
			var memory = 100000.Times(i => i).ToArray().AsMemory();
			var mmapped = memory.Map(x => x * 5);
			Assert.That((nint) Unsafe.AsPointer(ref mmapped.Span[0]), Is.EqualTo((nint) Unsafe.AsPointer(ref memory.Span[0])));
			Assert.That(memory.AsEnumerable(), Is.EqualTo(100000.Times(i => i * 5)));
		});
	}

	[Test]
	public unsafe void ParallelMap() {
		Assert.Multiple(() => {
			var espan = Array.Empty<byte>().AsSpan();
			Assert.That(espan.ParallelMap(x => x).Length, Is.EqualTo(0));
			
			var span = 100000.Times(i => i).ToArray().AsSpan();
			var mapped = span.ParallelMap(x => x * 5);
			Assert.That((nint) Unsafe.AsPointer(ref mapped[0]), Is.EqualTo((nint) Unsafe.AsPointer(ref span[0])));
			Assert.That(span.AsEnumerable(), Is.EqualTo(100000.Times(i => i * 5)));
			
			var memory = 100000.Times(i => i).ToArray().AsMemory();
			var mmapped = memory.ParallelMap(x => x * 5);
			Assert.That((nint) Unsafe.AsPointer(ref mmapped.Span[0]), Is.EqualTo((nint) Unsafe.AsPointer(ref memory.Span[0])));
			Assert.That(memory.AsEnumerable(), Is.EqualTo(100000.Times(i => i * 5)));
		});
	}
}