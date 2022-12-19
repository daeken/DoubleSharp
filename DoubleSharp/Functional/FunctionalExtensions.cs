namespace DoubleSharp.Functional;

/// <summary>DoubleSharp functional extensions.</summary>
public static class FunctionalExtensions {

	/// <summary>
	/// Returns the composition of two specified functions.
	/// </summary>
	/// <typeparam name="TInput">The input type of the <paramref name="inner"/> function.</typeparam>
	/// <typeparam name="TInter">The intermediate type that is returned by the <paramref name="inner"/> function and consumed by the <paramref name="outer"/> function.</typeparam>
	/// <typeparam name="TOutput">The output type of the <paramref name="outer"/> function.</typeparam>
	/// <param name="inner">The inner function.</param>
	/// <param name="outer">The outer function.</param>
	/// <returns>A <see cref="Func{TInput, TOutput}"/> representing the composition of the two functions.</returns>
	public static Func<TInput, TOutput> Compose<TInput, TInter, TOutput>(this Func<TInput, TInter> inner, Func<TInter, TOutput> outer) =>
		x => outer(inner(x));

	/// <summary>
	/// Returns the composition of three specified functions.
	/// </summary>
	/// <typeparam name="TInput">The input type of the <paramref name="inner1"/> function.</typeparam>
	/// <typeparam name="TInter1">The intermediate type that is returned by the <paramref name="inner1"/> function and consumed by the <paramref name="inner2"/> function.</typeparam>
	/// <typeparam name="TInter2">The intermediate type that is returned by the <paramref name="inner2"/> function and consumed by the <paramref name="outer"/> function.</typeparam>
	/// <typeparam name="TOutput">The output type of the <paramref name="outer"/> function.</typeparam>
	/// <param name="inner1">The first inner function.</param>
	/// <param name="inner2">The second inner function.</param>
	/// <param name="outer">The outer function.</param>
	/// <returns>A <see cref="Func{TInput, TOutput}"/> representing the composition of the three functions.</returns>
	public static Func<TInput, TOutput> Compose<TInput, TInter1, TInter2, TOutput>(
	  this Func<TInput, TInter1> inner1,
	  Func<TInter1, TInter2> inner2,
	  Func<TInter2, TOutput> outer) =>
		x => outer(inner2(inner1(x)));

	/// <summary>
	/// Returns the composition of four specified functions.
	/// </summary>
	/// <typeparam name="TInput">The input type of the <paramref name="inner1"/> function.</typeparam>
	/// <typeparam name="TInter1">The intermediate type that is returned by the <paramref name="inner1"/> function and consumed by the <paramref name="inner2"/> function.</typeparam>
	/// <typeparam name="TInter2">The intermediate type that is returned by the <paramref name="inner2"/> function and consumed by the <paramref name="inner3"/> function.</typeparam>
	/// <typeparam name="TInter3">The intermediate type that is returned by the <paramref name="inner3"/> function and consumed by the <paramref name="outer"/> function.</typeparam>
	/// <typeparam name="TOutput">The output type of the <paramref name="outer"/> function.</typeparam>
	/// <param name="inner1">The first inner function.</param>
	/// <param name="inner2">The second inner function.</param>
	/// <param name="inner3">The third inner function.</param>
	/// <param name="outer">The outer function.</param>
	/// <returns>A <see cref="Func{TInput, TOutput}"/> representing the composition of the four functions.</returns>
	public static Func<TInput, TOutput> Compose<TInput, TInter1, TInter2, TInter3, TOutput>(
	  this Func<TInput, TInter1> inner1,
	  Func<TInter1, TInter2> inner2,
	  Func<TInter2, TInter3> inner3,
	  Func<TInter3, TOutput> outer) =>
		x => outer(inner3(inner2(inner1(x))));

	/// <summary>
	/// Returns the composition of five specified functions.
	/// </summary>
	/// <typeparam name="TInput">The input type of the <paramref name="inner1"/> function.</typeparam>
	/// <typeparam name="TInter1">The intermediate type that is returned by the <paramref name="inner1"/> function and consumed by the <paramref name="inner2"/> function.</typeparam>
	/// <typeparam name="TInter2">The intermediate type that is returned by the <paramref name="inner2"/> function and consumed by the <paramref name="inner3"/> function.</typeparam>
	/// <typeparam name="TInter3">The intermediate type that is returned by the <paramref name="inner3"/> function and consumed by the <paramref name="inner4"/> function.</typeparam>
	/// <typeparam name="TInter4">The intermediate type that is returned by the <paramref name="inner4"/> function and consumed by the <paramref name="outer"/> function.</typeparam>
	/// <typeparam name="TOutput">The output type of the <paramref name="outer"/> function.</typeparam>
	/// <param name="inner1">The first inner function.</param>
	/// <param name="inner2">The second inner function.</param>
	/// <param name="inner3">The third inner function.</param>
	/// <param name="inner4">The fourth inner function.</param>
	/// <param name="outer">The outer function.</param>
	/// <returns>A <see cref="Func{TInput, TOutput}"/> representing the composition of the five functions.</returns>
	public static Func<TInput, TOutput> Compose<TInput, TInter1, TInter2, TInter3, TInter4, TOutput>(
	  this Func<TInput, TInter1> inner1,
	  Func<TInter1, TInter2> inner2,
	  Func<TInter2, TInter3> inner3,
	  Func<TInter3, TInter4> inner4,
	  Func<TInter4, TOutput> outer) =>
		x => outer(inner4(inner3(inner2(inner1(x)))));

	/// <summary>
	/// Returns the composition of six specified functions.
	/// </summary>
	/// <typeparam name="TInput">The input type of the <paramref name="inner1"/> function.</typeparam>
	/// <typeparam name="TInter1">The intermediate type that is returned by the <paramref name="inner1"/> function and consumed by the <paramref name="inner2"/> function.</typeparam>
	/// <typeparam name="TInter2">The intermediate type that is returned by the <paramref name="inner2"/> function and consumed by the <paramref name="inner3"/> function.</typeparam>
	/// <typeparam name="TInter3">The intermediate type that is returned by the <paramref name="inner3"/> function and consumed by the <paramref name="inner4"/> function.</typeparam>
	/// <typeparam name="TInter4">The intermediate type that is returned by the <paramref name="inner4"/> function and consumed by the <paramref name="inner5"/> function.</typeparam>
	/// <typeparam name="TInter5">The intermediate type that is returned by the <paramref name="inner5"/> function and consumed by the <paramref name="outer"/> function.</typeparam>
	/// <typeparam name="TOutput">The output type of the <paramref name="outer"/> function.</typeparam>
	/// <param name="inner1">The first inner function.</param>
	/// <param name="inner2">The second inner function.</param>
	/// <param name="inner3">The third inner function.</param>
	/// <param name="inner4">The fourth inner function.</param>
	/// <param name="inner5">The fifth inner function.</param>
	/// <param name="outer">The outer function.</param>
	/// <returns>A <see cref="Func{TInput, TOutput}"/> representing the composition of the six functions.</returns>
	public static Func<TInput, TOutput> Compose<TInput, TInter1, TInter2, TInter3, TInter4, TInter5, TOutput>(
	  this Func<TInput, TInter1> inner1,
	  Func<TInter1, TInter2> inner2,
	  Func<TInter2, TInter3> inner3,
	  Func<TInter3, TInter4> inner4,
	  Func<TInter4, TInter5> inner5,
	  Func<TInter5, TOutput> outer) =>
		x => outer(inner5(inner4(inner3(inner2(inner1(x))))));

	/// <summary>
	/// Returns the composition of seven specified functions.
	/// </summary>
	/// <typeparam name="TInput">The input type of the <paramref name="inner1"/> function.</typeparam>
	/// <typeparam name="TInter1">The intermediate type that is returned by the <paramref name="inner1"/> function and consumed by the <paramref name="inner2"/> function.</typeparam>
	/// <typeparam name="TInter2">The intermediate type that is returned by the <paramref name="inner2"/> function and consumed by the <paramref name="inner3"/> function.</typeparam>
	/// <typeparam name="TInter3">The intermediate type that is returned by the <paramref name="inner3"/> function and consumed by the <paramref name="inner4"/> function.</typeparam>
	/// <typeparam name="TInter4">The intermediate type that is returned by the <paramref name="inner4"/> function and consumed by the <paramref name="inner5"/> function.</typeparam>
	/// <typeparam name="TInter5">The intermediate type that is returned by the <paramref name="inner5"/> function and consumed by the <paramref name="inner6"/> function.</typeparam>
	/// <typeparam name="TInter6">The intermediate type that is returned by the <paramref name="inner6"/> function and consumed by the <paramref name="outer"/> function.</typeparam>
	/// <typeparam name="TOutput">The output type of the <paramref name="outer"/> function.</typeparam>
	/// <param name="inner1">The first inner function.</param>
	/// <param name="inner2">The second inner function.</param>
	/// <param name="inner3">The third inner function.</param>
	/// <param name="inner4">The fourth inner function.</param>
	/// <param name="inner5">The fifth inner function.</param>
	/// <param name="inner6">The sixth inner function.</param>
	/// <param name="outer">The outer function.</param>
	/// <returns>A <see cref="Func{TInput, TOutput}"/> representing the composition of the seven functions.</returns>
	public static Func<TInput, TOutput> Compose<TInput, TInter1, TInter2, TInter3, TInter4, TInter5, TInter6, TOutput>(
	  this Func<TInput, TInter1> inner1,
	  Func<TInter1, TInter2> inner2,
	  Func<TInter2, TInter3> inner3,
	  Func<TInter3, TInter4> inner4,
	  Func<TInter4, TInter5> inner5,
	  Func<TInter5, TInter6> inner6,
	  Func<TInter6, TOutput> outer) =>
		x => outer(inner6(inner5(inner4(inner3(inner2(inner1(x)))))));

	/// <summary>
	/// Returns the composition of eight specified functions.
	/// </summary>
	/// <typeparam name="TInput">The input type of the <paramref name="inner1"/> function.</typeparam>
	/// <typeparam name="TInter1">The intermediate type that is returned by the <paramref name="inner1"/> function and consumed by the <paramref name="inner2"/> function.</typeparam>
	/// <typeparam name="TInter2">The intermediate type that is returned by the <paramref name="inner2"/> function and consumed by the <paramref name="inner3"/> function.</typeparam>
	/// <typeparam name="TInter3">The intermediate type that is returned by the <paramref name="inner3"/> function and consumed by the <paramref name="inner4"/> function.</typeparam>
	/// <typeparam name="TInter4">The intermediate type that is returned by the <paramref name="inner4"/> function and consumed by the <paramref name="inner5"/> function.</typeparam>
	/// <typeparam name="TInter5">The intermediate type that is returned by the <paramref name="inner5"/> function and consumed by the <paramref name="inner6"/> function.</typeparam>
	/// <typeparam name="TInter6">The intermediate type that is returned by the <paramref name="inner6"/> function and consumed by the <paramref name="inner7"/> function.</typeparam>
	/// <typeparam name="TInter7">The intermediate type that is returned by the <paramref name="inner7"/> function and consumed by the <paramref name="outer"/> function.</typeparam>
	/// <typeparam name="TOutput">The output type of the <paramref name="outer"/> function.</typeparam>
	/// <param name="inner1">The first inner function.</param>
	/// <param name="inner2">The second inner function.</param>
	/// <param name="inner3">The third inner function.</param>
	/// <param name="inner4">The fourth inner function.</param>
	/// <param name="inner5">The fifth inner function.</param>
	/// <param name="inner6">The sixth inner function.</param>
	/// <param name="inner7">The seventh inner function.</param>
	/// <param name="outer">The outer function.</param>
	/// <returns>A <see cref="Func{TInput, TOutput}"/> representing the composition of the eight functions.</returns>
	public static Func<TInput, TOutput> Compose<TInput, TInter1, TInter2, TInter3, TInter4, TInter5, TInter6, TInter7, TOutput>(
	  this Func<TInput, TInter1> inner1,
	  Func<TInter1, TInter2> inner2,
	  Func<TInter2, TInter3> inner3,
	  Func<TInter3, TInter4> inner4,
	  Func<TInter4, TInter5> inner5,
	  Func<TInter5, TInter6> inner6,
	  Func<TInter6, TInter7> inner7,
	  Func<TInter7, TOutput> outer) =>
		x => outer(inner7(inner6(inner5(inner4(inner3(inner2(inner1(x))))))));

}