namespace DoubleSharp.Functional; 

public static class FunctionalExtensions {
	public static Func<T1, TOut> Compose<T1, T2, TOut>(this Func<T1, T2> inner, Func<T2, TOut> outer) =>
		x => outer(inner(x));
	public static Func<T1, TOut> Compose<T1, T2, T3, TOut>(this Func<T1, T2> inner1, Func<T2, T3> inner2, Func<T3, TOut> outer) =>
		x => outer(inner2(inner1(x)));
}