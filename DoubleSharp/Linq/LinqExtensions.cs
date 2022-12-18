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
}