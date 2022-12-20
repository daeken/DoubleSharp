using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DoubleSharp.Buffers; 

public static class BufferExtensions {
	const string Printable = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_-[]{}`~!@#$%^&*()-=\\|;:'\",./<>?";
	public static void HexDump(this ReadOnlySpan<byte> buffer, TextWriter? tw = null) {
		tw ??= Console.Out;
		for(var i = 0; i < buffer.Length; i += 16) {
			tw.Write($"{i:X4} | ");
			for(var j = 0; j < 16; ++j) {
				tw.Write(i + j >= buffer.Length ? $"   " : $"{buffer[i + j]:X2} ");
				if(j == 7) tw.Write(" ");
			}
			tw.Write("| ");
			for(var j = 0; j < 16; ++j) {
				if(i + j >= buffer.Length) break;
				tw.Write(Printable.Contains((char) buffer[i + j]) ? new string((char) buffer[i + j], 1) : ".");
				if(j == 7) tw.Write(" ");
			}
			tw.WriteLine();
		}
		tw.WriteLine($"{buffer.Length:X4}");
	}

	public static void HexDump<T>(this ReadOnlySpan<T> buffer, TextWriter? tw = null) where T : struct =>
		HexDump(buffer.Cast<T, byte>(), tw);

	public static void HexDump<T>(this T[] buffer, TextWriter? tw = null) where T : struct =>
		HexDump((ReadOnlySpan<T>) buffer, tw);

	public static string ToHexDump(this ReadOnlySpan<byte> buffer) {
		using var sw = new StringWriter();
		buffer.HexDump(sw);
		return sw.ToString();
	}

	public static string ToHexDump(this byte[] buffer) =>
		ToHexDump((ReadOnlySpan<byte>) buffer);
	
	public static string ToHexDump<T>(this ReadOnlySpan<T> buffer) where T : struct {
		using var sw = new StringWriter();
		buffer.HexDump(sw);
		return sw.ToString().TrimEnd();
	}

	public static string ToHexDump<T>(this T[] buffer) where T : struct =>
		ToHexDump((ReadOnlySpan<T>) buffer);

	public static unsafe IEnumerable<T> AsEnumerable<T>(this Span<T> span) where T : unmanaged {
		fixed(T* ptr = span)
			return RefEnumerable<T>(new(ptr), span.Length);
	}

	static IEnumerable<T> RefEnumerable<T>(PointerHolder<T> ptr, int length) where T : unmanaged {
		for(var i = 0; i < length; ++i)
			yield return ptr[i];
	}

	public static IEnumerable<T> AsEnumerable<T>(this Memory<T> memory) {
		var len = memory.Length;
		for(var i = 0; i < len; ++i)
			yield return memory.Span[i];
	}

	public static Span<T> Map<T>(this Span<T> span, Func<T, T> functor) {
		for(var i = 0; i < span.Length; ++i)
			span[i] = functor(span[i]);
		return span;
	}

	public static Memory<T> Map<T>(this Memory<T> memory, Func<T, T> functor) {
		memory.Span.Map(functor);
		return memory;
	}

	public static unsafe Span<T> ParallelMap<T>(this Span<T> span, Func<T, T> functor) {
		if(span.Length == 0) return span;
#pragma warning disable CS8500
		var ptr = (T*) Unsafe.AsPointer(ref span[0]);
		Parallel.For(0, span.Length, i =>
			ptr[i] = functor(ptr[i]));
#pragma warning restore CS8500
		return span;
	}

	public static Memory<T> ParallelMap<T>(this Memory<T> memory, Func<T, T> functor) {
		memory.Span.ParallelMap(functor);
		return memory;
	}

	public static Span<TTo> Cast<TFrom, TTo>(this Span<TFrom> from)
		where TFrom : struct
		where TTo : struct
		=> MemoryMarshal.Cast<TFrom, TTo>(from);

	public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(this ReadOnlySpan<TFrom> from)
		where TFrom : struct
		where TTo : struct
		=> MemoryMarshal.Cast<TFrom, TTo>(from);

	public static Memory<TTo> Cast<TFrom, TTo>(ref this Memory<TFrom> from)
		where TFrom : unmanaged
		where TTo : unmanaged
	{
		if (typeof(TFrom) == typeof(TTo)) return (Memory<TTo>) (object) from;
		return new CastMemoryManager<TFrom, TTo>(from).Memory;
	}

	class CastMemoryManager<TFrom, TTo> : MemoryManager<TTo>
		where TFrom : unmanaged
		where TTo : unmanaged
	{
		readonly Memory<TFrom> From;

		public CastMemoryManager(Memory<TFrom> from) => From = from;
		public override Span<TTo> GetSpan() =>
			From.Span.Cast<TFrom, TTo>();
		[ExcludeFromCodeCoverage]
		protected override void Dispose(bool disposing) { }
		[ExcludeFromCodeCoverage]
		public override MemoryHandle Pin(int elementIndex = 0) =>
			throw new NotSupportedException();
		[ExcludeFromCodeCoverage]
		public override void Unpin() => 
			throw new NotSupportedException();
	}

	unsafe class PointerHolder<T> where T : unmanaged {
		readonly T* Pointer;

		public PointerHolder(T* pointer) => Pointer = pointer;
		internal ref T this[int index] => ref Pointer[index];
	}
}