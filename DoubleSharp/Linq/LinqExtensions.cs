using DoubleSharp.Random;

namespace DoubleSharp.Linq; 

public static class LinqExtensions {
	public static IEnumerable<(int i, T x)> Enumerate<T>(this IEnumerable<T> query) =>
		query.Select((x, i) => (i, x));

	public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(
		this IEnumerable<(TKey Key, TValue Value)> query
	) where TKey : notnull =>
		query.ToDictionary(x => x.Key, x => x.Value);

	public static void ForEach<T>(this IEnumerable<T> query, Action<T> functor) {
		var temp = query.Select<T, object>(x => {
			functor(x);
			return null!;
		});
		var enumerator = temp.GetEnumerator();
		while(enumerator.MoveNext()) {}
		enumerator.Dispose();
	}

	public static Dictionary<TKey, IEnumerable<TValue>> DictGroupBy<TKey, TValue>(
		this IEnumerable<TValue> query, Func<TValue, TKey> by
	) where TKey : notnull =>
		query.GroupBy(by).ToDictionary(x => x.Key, x => (IEnumerable<TValue>) x);

	public static Dictionary<TKey, IEnumerable<TReduced>> DictGroupBy<TValue, TKey, TReduced>(
		this IEnumerable<TValue> query, Func<TValue, TKey> by, Func<TValue, TReduced> reduce
	) where TKey : notnull =>
		query.GroupBy(by).ToDictionary(x => x.Key, x => x.Select(reduce));

	public static Dictionary<TKey, List<TValue>> DictGroupByLists<TKey, TValue>(
		this IEnumerable<TValue> query, Func<TValue, TKey> by
	) where TKey : notnull =>
		query.GroupBy(by).ToDictionary(x => x.Key, x => x.ToList());

	public static Dictionary<TKey, List<TReduced>> DictGroupByLists<TValue, TKey, TReduced>(
		this IEnumerable<TValue> query, Func<TValue, TKey> by, Func<TValue, TReduced> reduce
	) where TKey : notnull =>
		query.GroupBy(by).ToDictionary(x => x.Key, x => x.Select(reduce).ToList());

	public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> query) =>
		query.SelectMany(x => x);
	
	public static void Shuffle<T>(this IList<T> list) {
		var n = list.Count;
		while(n > 1) {
			n--;
			var k = Rng.Next(n + 1);
			(list[k], list[n]) = (list[n], list[k]);
		}
	}

	public static List<T> Shuffled<T>(this IEnumerable<T> query) {
		var list = query.ToList();
		list.Shuffle();
		return list;
	}
}