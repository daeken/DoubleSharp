namespace DoubleSharp.Concurrency; 

public static class Extensions {
	public static T Locked<T>(this T @object, Action functor) {
		if(@object == null) throw new ArgumentNullException(nameof(@object));
		lock(@object)
			functor();
		return @object;
	}
	
	public static T Locked<T>(this T @object, Action<T> functor) {
		if(@object == null) throw new ArgumentNullException(nameof(@object));
		lock(@object)
			functor(@object);
		return @object;
	}

	public static uint Increment(this ref uint value) =>
		Interlocked.Increment(ref value);
	public static ulong Increment(this ref ulong value) =>
		Interlocked.Increment(ref value);
	public static int Increment(this ref int value) =>
		Interlocked.Increment(ref value);
	public static long Increment(this ref long value) =>
		Interlocked.Increment(ref value);

	public static uint Decrement(this ref uint value) =>
		Interlocked.Decrement(ref value);
	public static ulong Decrement(this ref ulong value) =>
		Interlocked.Decrement(ref value);
	public static int Decrement(this ref int value) =>
		Interlocked.Decrement(ref value);
	public static long Decrement(this ref long value) =>
		Interlocked.Decrement(ref value);
}