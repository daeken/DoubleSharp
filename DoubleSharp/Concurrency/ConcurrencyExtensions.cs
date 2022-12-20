using System.Runtime.CompilerServices;

namespace DoubleSharp.Concurrency;

/// <summary>DoubleSharp concurrency extensions.</summary>
public static class ConcurrencyExtensions {

	/// <summary>
	/// Locks the target object and performs the specified action.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="object">The object.</param>
	/// <param name="action">The <see cref="Action"/> delegate to perform.</param>
	/// <returns>The provided <paramref name="object"/>.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="object"/> is null.</exception>
	public static T Locked<T>(this T @object, Action action) {
		if (@object == null) throw new ArgumentNullException(nameof(@object));
		lock (@object)
			action();
		return @object;
	}

	/// <summary>
	/// Locks the target object and performs the specified action on it.
	/// </summary>
	/// <typeparam name="T">The type of the object.</typeparam>
	/// <param name="object">The object.</param>
	/// <param name="action">The <see cref="Action{T}"/> delegate to perform on the object.</param>
	/// <returns>The provided <paramref name="object"/>.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="object"/> is null.</exception>
	public static T Locked<T>(this T @object, Action<T> action) {
		if (@object == null) throw new ArgumentNullException(nameof(@object));
		lock (@object)
			action(@object);
		return @object;
	}

	/// <summary>
	/// Increments this variable and stores the result, as an atomic operation.
	/// </summary>
	/// <param name="value">The variable whose value is to be incremented.</param>
	/// <returns>The incremented value.</returns>
	/// <exception cref="NullReferenceException">The address of <paramref name="value"/> is a <c>null</c> pointer.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint Increment(this ref uint value) =>
		Interlocked.Increment(ref value);

	/// <inheritdoc cref="Increment(ref uint)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong Increment(this ref ulong value) =>
		Interlocked.Increment(ref value);

	/// <inheritdoc cref="Increment(ref uint)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Increment(this ref int value) =>
		Interlocked.Increment(ref value);

	/// <inheritdoc cref="Increment(ref uint)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Increment(this ref long value) =>
		Interlocked.Increment(ref value);

	/// <summary>
	/// Decrements this variable and stores the result, as an atomic operation.
	/// </summary>
	/// <param name="value">The variable whose value is to be decremented.</param>
	/// <returns>The decremented value.</returns>
	/// <exception cref="NullReferenceException">The address of <paramref name="value"/> is a <c>null</c> pointer.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint Decrement(this ref uint value) =>
		Interlocked.Decrement(ref value);

	/// <inheritdoc cref="Decrement(ref uint)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong Decrement(this ref ulong value) =>
		Interlocked.Decrement(ref value);

	/// <inheritdoc cref="Decrement(ref uint)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Decrement(this ref int value) =>
		Interlocked.Decrement(ref value);

	/// <inheritdoc cref="Decrement(ref uint)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Decrement(this ref long value) =>
		Interlocked.Decrement(ref value);

	/// <summary>
	/// Adds a value to this variable and stores the result, as an atomic operation.
	/// </summary>
	/// <param name="variable">The variable containing the first number to be added. The sum of the two numbers will be stored here.</param>
	/// <param name="value">The value to be added to the variable at <paramref name="variable"/>.</param>
	/// <exception cref="NullReferenceException">The address of <paramref name="variable"/> is a <c>null</c> pointer.</exception>
	/// <returns>The value that was stored as a result of this operation.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Add(this ref int variable, int value) =>
		Interlocked.Add(ref variable, value);

	/// <inheritdoc cref="Add(ref int, int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Add(this ref long variable, long value) =>
		Interlocked.Add(ref variable, value);

	/// <inheritdoc cref="Add(ref int, int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint Add(this ref uint variable, uint value) =>
		Interlocked.Add(ref variable, value);

	/// <inheritdoc cref="Add(ref int, int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong Add(this ref ulong variable, ulong value) =>
		Interlocked.Add(ref variable, value);

	/// <summary>
	/// Bitwise "ands" a value with this variable and stores the result, as an atomic operation.
	/// </summary>
	/// <param name="variable">The variable containing the first number to be combined. The result is stored here.</param>
	/// <param name="value">The value to be combined with <paramref name="variable"/>.</param>
	/// <exception cref="NullReferenceException">The address of <paramref name="variable"/> is a <c>null</c> pointer.</exception>
	/// <returns>The original value of the variable.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int And(this ref int variable, int value) =>
		Interlocked.And(ref variable, value);

	/// <inheritdoc cref="And(ref int, int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long And(this ref long variable, long value) =>
		Interlocked.And(ref variable, value);

	/// <inheritdoc cref="And(ref int, int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint And(this ref uint variable, uint value) =>
		Interlocked.And(ref variable, value);

	/// <inheritdoc cref="And(ref int, int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong And(this ref ulong variable, ulong value) =>
		Interlocked.And(ref variable, value);

	/// <summary>
	/// Bitwise "ors" a value with this variable and stores the result, as an atomic operation.
	/// </summary>
	/// <param name="variable">The variable containing the first number to be combined. The result is stored here.</param>
	/// <param name="value">The value to be combined with <paramref name="variable"/>.</param>
	/// <exception cref="NullReferenceException">The address of <paramref name="variable"/> is a <c>null</c> pointer.</exception>
	/// <returns>The original value of the variable.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Or(this ref int variable, int value) =>
		Interlocked.Or(ref variable, value);

	/// <inheritdoc cref="Or(ref int, int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Or(this ref long variable, long value) =>
		Interlocked.Or(ref variable, value);

	/// <inheritdoc cref="Or(ref int, int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint Or(this ref uint variable, uint value) =>
		Interlocked.Or(ref variable, value);

	/// <inheritdoc cref="Or(ref int, int)"/>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong Or(this ref ulong variable, ulong value) =>
		Interlocked.Or(ref variable, value);

}