using DoubleSharp.Buffers;
using DoubleSharp.IO;
using DoubleSharp.MathPlus;

namespace Tests; 

[TestFixture]
public class IOTests {
	[Test]
	public void VectorWrite() {
		Assert.Multiple(() => {
			var vec = (1, 2, 3, 4).ToVector();
			var bytes = vec.ToArray().AsSpan().Cast<float, byte>().ToArray();
			using(var ms = new MemoryStream()) {
				using var bw = new BinaryWriter(ms);
				bw.Write(vec.XY());
				bw.Flush();
				Assert.That(ms.ToArray(), Is.EquivalentTo(bytes.Take(2 * 4)));
			}
			using(var ms = new MemoryStream()) {
				using var bw = new BinaryWriter(ms);
				bw.Write(vec.XYZ());
				bw.Flush();
				Assert.That(ms.ToArray(), Is.EquivalentTo(bytes.Take(3 * 4)));
			}
			using(var ms = new MemoryStream()) {
				using var bw = new BinaryWriter(ms);
				bw.Write(vec);
				bw.Flush();
				Assert.That(ms.ToArray(), Is.EquivalentTo(bytes));
			}
		});
	}
	
	[Test]
	public void VectorRead() {
		Assert.Multiple(() => {
			var vec = (1, 2, 3, 4).ToVector();
			var bytes = vec.ToArray().AsSpan().Cast<float, byte>().ToArray();
			using(var ms = new MemoryStream(bytes.Take(2 * 4).ToArray())) {
				using var br = new BinaryReader(ms);
				Assert.That(br.ReadVector2(), Is.EqualTo(vec.XY()));
			}
			using(var ms = new MemoryStream(bytes.Take(3 * 4).ToArray())) {
				using var br = new BinaryReader(ms);
				Assert.That(br.ReadVector3(), Is.EqualTo(vec.XYZ()));
			}
			using(var ms = new MemoryStream(bytes)) {
				using var br = new BinaryReader(ms);
				Assert.That(br.ReadVector4(), Is.EqualTo(vec));
			}
		});
	}
}