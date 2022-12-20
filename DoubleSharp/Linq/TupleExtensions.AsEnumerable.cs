namespace DoubleSharp.Linq; 

/// <summary>DoubleSharp extensions to convert homogenously-typed tuples to IEnumerables.</summary>
public static class TupleExtensions {
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1) tuple) {
		yield return tuple._0;
		yield return tuple._1;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10, T _11) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
		yield return tuple._11;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10, T _11, T _12) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
		yield return tuple._11;
		yield return tuple._12;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10, T _11, T _12, T _13) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
		yield return tuple._11;
		yield return tuple._12;
		yield return tuple._13;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10, T _11, T _12, T _13, T _14) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
		yield return tuple._11;
		yield return tuple._12;
		yield return tuple._13;
		yield return tuple._14;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10, T _11, T _12, T _13, T _14, T _15) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
		yield return tuple._11;
		yield return tuple._12;
		yield return tuple._13;
		yield return tuple._14;
		yield return tuple._15;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10, T _11, T _12, T _13, T _14, T _15, T _16) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
		yield return tuple._11;
		yield return tuple._12;
		yield return tuple._13;
		yield return tuple._14;
		yield return tuple._15;
		yield return tuple._16;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10, T _11, T _12, T _13, T _14, T _15, T _16, T _17) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
		yield return tuple._11;
		yield return tuple._12;
		yield return tuple._13;
		yield return tuple._14;
		yield return tuple._15;
		yield return tuple._16;
		yield return tuple._17;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10, T _11, T _12, T _13, T _14, T _15, T _16, T _17, T _18) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
		yield return tuple._11;
		yield return tuple._12;
		yield return tuple._13;
		yield return tuple._14;
		yield return tuple._15;
		yield return tuple._16;
		yield return tuple._17;
		yield return tuple._18;
	}
	/// <summary>
	/// Enumerates the components of a tuple when all the types are the same.
	/// </summary>
	/// <typeparam name="T">The type of each element of the <paramref name="tuple"/>.</typeparam>
	/// <param name="tuple"></param>
	/// <returns>An enumerable sequence of the tuple values</returns>
	public static IEnumerable<T> AsEnumerable<T>(this (T _0, T _1, T _2, T _3, T _4, T _5, T _6, T _7, T _8, T _9, T _10, T _11, T _12, T _13, T _14, T _15, T _16, T _17, T _18, T _19) tuple) {
		yield return tuple._0;
		yield return tuple._1;
		yield return tuple._2;
		yield return tuple._3;
		yield return tuple._4;
		yield return tuple._5;
		yield return tuple._6;
		yield return tuple._7;
		yield return tuple._8;
		yield return tuple._9;
		yield return tuple._10;
		yield return tuple._11;
		yield return tuple._12;
		yield return tuple._13;
		yield return tuple._14;
		yield return tuple._15;
		yield return tuple._16;
		yield return tuple._17;
		yield return tuple._18;
		yield return tuple._19;
	}
}