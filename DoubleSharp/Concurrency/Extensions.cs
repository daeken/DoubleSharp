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
}