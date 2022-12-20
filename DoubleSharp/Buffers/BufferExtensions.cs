using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DoubleSharp.Buffers; 

/// <summary>DoubleSharp Buffer extensions.</summary>
public static class BufferExtensions {
	const string Printable = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_-[]{}`~!@#$%^&*()-=\\|;:'\",./<>?";
	/// <summary>
	/// Prints a hex dump to the Console or an optional TextWriter.
	/// </summary>
	/// <param name="buffer">The buffer to convert to a hex dump.</param>
	/// <param name="tw">An optional TextWriter to which to write.</param>
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

	/// <inheritdoc cref="HexDump(ReadOnlySpan{byte}, TextWriter?)" />
	public static void HexDump<T>(this ReadOnlySpan<T> buffer, TextWriter? tw = null) where T : struct =>
		HexDump(buffer.Cast<T, byte>(), tw);

	/// <inheritdoc cref="HexDump(ReadOnlySpan{byte}, TextWriter?)" />
	public static void HexDump<T>(this T[] buffer, TextWriter? tw = null) where T : struct =>
		HexDump((ReadOnlySpan<T>) buffer, tw);

    /// <summary>
    /// Returns a hex dump of the provided buffer as a string.
    /// </summary>
    /// <param name="buffer">The buffer to convert to a hex dump.</param>
    /// <returns>The hex dump.</returns>
    public static string ToHexDump(this ReadOnlySpan<byte> buffer) {
		using var sw = new StringWriter();
		buffer.HexDump(sw);
		return sw.ToString();
	}

	/// <inheritdoc cref="ToHexDump(ReadOnlySpan{byte})" />
	public static string ToHexDump(this byte[] buffer) =>
		ToHexDump((ReadOnlySpan<byte>) buffer);
	
	/// <inheritdoc cref="ToHexDump(ReadOnlySpan{byte})" />
	public static string ToHexDump<T>(this ReadOnlySpan<T> buffer) where T : struct {
		using var sw = new StringWriter();
		buffer.HexDump(sw);
		return sw.ToString().TrimEnd();
	}

	/// <inheritdoc cref="ToHexDump(ReadOnlySpan{byte})" />
	public static string ToHexDump<T>(this T[] buffer) where T : struct =>
		ToHexDump((ReadOnlySpan<T>) buffer);

	/// <summary>
	/// WARNING: This method is a footgun. If the Span disappears or moves during enumeration,
	/// BAD THINGS will happen.
	///
	/// Makes an IEnumerable from a given Span.
	/// </summary>
	/// <param name="span">The input Span.</param>
	/// <typeparam name="T">The type of Span.</typeparam>
	/// <returns>An IEnumerable for <paramref name="span"/>.</returns>
	public static unsafe IEnumerable<T> AsEnumerable<T>(this Span<T> span) where T : unmanaged {
		fixed(T* ptr = span)
			return RefEnumerable<T>(new(ptr), span.Length);
	}

	static IEnumerable<T> RefEnumerable<T>(PointerHolder<T> ptr, int length) where T : unmanaged {
		for(var i = 0; i < length; ++i)
			yield return ptr[i];
	}

	/// <summary>
	/// Makes an IEnumerable from a given Memory.
	/// </summary>
	/// <param name="memory">The input Memory.</param>
	/// <typeparam name="T">The type of Memory.</typeparam>
	/// <returns>An IEnumerable for <paramref name="memory"/>.</returns>
	public static IEnumerable<T> AsEnumerable<T>(this Memory<T> memory) {
		var len = memory.Length;
		for(var i = 0; i < len; ++i)
			yield return memory.Span[i];
	}

	/// <summary>
	/// Maps each element of a Span to a new value.
	/// </summary>
	/// <param name="span">The input Span.</param>
	/// <param name="functor">The function to apply to each value.</param>
	/// <typeparam name="T">The type of the Span.</typeparam>
	/// <returns>The original Span, <paramref name="span"/>.</returns>
	public static Span<T> Map<T>(this Span<T> span, Func<T, T> functor) {
		for(var i = 0; i < span.Length; ++i)
			span[i] = functor(span[i]);
		return span;
	}

	/// <summary>
	/// Maps each element of a Memory to a new value.
	/// </summary>
	/// <param name="memory">The input Memory.</param>
	/// <param name="functor">The function to apply to each value.</param>
	/// <typeparam name="T">The type of the Span.</typeparam>
	/// <returns>The original Memory, <paramref name="memory"/>.</returns>
	public static Memory<T> Map<T>(this Memory<T> memory, Func<T, T> functor) {
		memory.Span.Map(functor);
		return memory;
	}

	/// <summary>
	/// Maps each element of a Span to a new value in parallel.
	/// </summary>
	/// <param name="span">The input Span.</param>
	/// <param name="functor">The function to apply to each value.</param>
	/// <typeparam name="T">The type of the Span.</typeparam>
	/// <returns>The original Span, <paramref name="span"/>.</returns>
	public static unsafe Span<T> ParallelMap<T>(this Span<T> span, Func<T, T> functor) {
		if(span.Length == 0) return span;
#pragma warning disable CS8500
		var ptr = (T*) Unsafe.AsPointer(ref span[0]);
		Parallel.For(0, span.Length, i =>
			ptr[i] = functor(ptr[i]));
#pragma warning restore CS8500
		return span;
	}

	/// <summary>
	/// Maps each element of a Memory to a new value in parallel.
	/// </summary>
	/// <param name="memory">The input Memory.</param>
	/// <param name="functor">The function to apply to each value.</param>
	/// <typeparam name="T">The type of the Span.</typeparam>
	/// <returns>The original Memory, <paramref name="memory"/>.</returns>
	public static Memory<T> ParallelMap<T>(this Memory<T> memory, Func<T, T> functor) {
		memory.Span.ParallelMap(functor);
		return memory;
	}

	/// <summary>
	/// Casts a Span from one type to another.
	/// </summary>
	/// <param name="from">The Span to cast.</param>
	/// <typeparam name="TFrom">The original Span type.</typeparam>
	/// <typeparam name="TTo">The destination Span type.</typeparam>
	/// <returns>The converted Span.</returns>
	public static Span<TTo> Cast<TFrom, TTo>(this Span<TFrom> from)
		where TFrom : struct
		where TTo : struct
		=> MemoryMarshal.Cast<TFrom, TTo>(from);

	/// <summary>
	/// Casts a ReadOnlySpan from one type to another.
	/// </summary>
	/// <param name="from">The ReadOnlySpan to cast.</param>
	/// <typeparam name="TFrom">The original ReadOnlySpan type.</typeparam>
	/// <typeparam name="TTo">The destination ReadOnlySpan type.</typeparam>
	/// <returns>The converted ReadOnlySpan.</returns>
	public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(this ReadOnlySpan<TFrom> from)
		where TFrom : struct
		where TTo : struct
		=> MemoryMarshal.Cast<TFrom, TTo>(from);

	/// <summary>
	/// Casts a Memory from one type to another.
	/// </summary>
	/// <param name="from">The Memory to cast.</param>
	/// <typeparam name="TFrom">The original Memory type.</typeparam>
	/// <typeparam name="TTo">The destination Memory type.</typeparam>
	/// <returns>The converted Memory.</returns>
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