using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using DoubleSharp.Random;

namespace DoubleSharp.Linq; 

/// <summary>DoubleSharp LINQ Extensions</summary>
public static class LinqExtensions {
	/// <summary>
	/// Projects each element of a sequence into a tuple of type (<see cref="int"/>, <typeparamref name="T"/>) representing the 0-based index of the element and its value.
	/// </summary>
	/// <typeparam name="T">The type of objects to enumerate.</typeparam>
	/// <param name="source">The source enumerable.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> whose elements are (<see cref="int"/>, <typeparamref name="T"/>) tuples containing the 0-based index and value of each element in the source enumerable.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	public static IEnumerable<(int i, T x)> Enumerate<T>(this IEnumerable<T> source) =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		source.Select((x, i) => (i, x));

	/// <summary>
	/// Creates a <see cref="Dictionary{TKey, TValue}"/> from an <see cref="IEnumerable{T}"/> containing tuples of type (<typeparamref name="TKey"/>, <typeparamref name="TValue"/>).
	/// </summary>
	/// <typeparam name="TKey">The type of the key.</typeparam>
	/// <typeparam name="TValue">The type of the value.</typeparam>
	/// <param name="source">The source enumerable.</param>
	/// <returns>A <see cref="Dictionary{TKey, TValue}"/> that contains elements of type <typeparamref name="TValue"/> selected from the input sequence.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(
		this IEnumerable<(TKey Key, TValue Value)> source
	) where TKey : notnull =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		source.ToDictionary(x => x.Key, x => x.Value);

	/// <summary>
	/// Performs the specified action on each element of the <see cref="IEnumerable{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of objects to enumerate.</typeparam>
	/// <param name="source">The source enumerable.</param>
	/// <param name="action">The <see cref="Action{T}"/> delegate to perform on each element of the <see cref="IEnumerable{T}"/>.</param>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="action"/> is null.</exception>
	public static void ForEach<T>(this IEnumerable<T> source, Action<T> action) {
		if (source == null) throw new ArgumentNullException(nameof(source));
		if (action == null) throw new ArgumentNullException(nameof(action));
		var temp = source.Select<T, object>(x => {
			action(x);
			return null!;
		});
		var enumerator = temp.GetEnumerator();
		while(enumerator.MoveNext()) {}
		enumerator.Dispose();
	}

	/// <summary>
	/// Groups the elements of a sequence according to a specified key selector function and projects the resulting groups into a dictionary.
	/// </summary>
	/// <typeparam name="TValue">The type of elements of source.</typeparam>
	/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector"/>.</typeparam>
	/// <param name="source">The source enumerable.</param>
	/// <param name="keySelector">A function to extract the key for each element.</param>
	/// <returns>A <c>Dictionary&lt;<typeparamref name="TKey"/>, IEnumerable&lt;<typeparamref name="TValue"/>&gt;&gt;</c> where each dictionary entry represents a group.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> is null.</exception>
	public static Dictionary<TKey, IEnumerable<TValue>> DictGroupBy<TValue, TKey>(
		this IEnumerable<TValue> source, Func<TValue, TKey> keySelector
	) where TKey : notnull =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		keySelector == null ? throw new ArgumentNullException(nameof(keySelector)) :
		source.GroupBy(keySelector).ToDictionary(x => x.Key, x => (IEnumerable<TValue>) x);

	/// <summary>
	/// Groups the elements of a sequence according to a specified key selector function and projects the resulting groups into a dictionary, with the elements of each group transformed using a specified function.
	/// </summary>
	/// <typeparam name="TValue">The type of elements of source.</typeparam>
	/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector"/>.</typeparam>
	/// <typeparam name="TResult">The type of the value returned by <paramref name="valueSelector"/>.</typeparam>
	/// <param name="source">The source enumerable.</param>
	/// <param name="keySelector">A function to extract the key for each element.</param>
	/// <param name="valueSelector">A transform function to apply to each group element.</param>
	/// <returns>A <c>Dictionary&lt;<typeparamref name="TKey"/>, IEnumerable&lt;<typeparamref name="TResult"/>&gt;&gt;</c> where each dictionary entry represents a group.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="valueSelector"/> is null.</exception>
	/// <remarks>The <paramref name="valueSelector"/> transform function is applied after grouping.</remarks>
	public static Dictionary<TKey, IEnumerable<TResult>> DictGroupBy<TValue, TKey, TResult>(
		this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, Func<TValue, TResult> valueSelector
	) where TKey : notnull =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		keySelector == null ? throw new ArgumentNullException(nameof(keySelector)) :
		valueSelector == null ? throw new ArgumentNullException(nameof(valueSelector)) :
		source.GroupBy(keySelector).ToDictionary(x => x.Key, x => x.Select(valueSelector));

	/// <summary>
	/// Groups the elements of a sequence according to a specified key selector function and projects the resulting groups into a dictionary.
	/// </summary>
	/// <typeparam name="TValue">The type of elements of source.</typeparam>
	/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector"/>.</typeparam>
	/// <param name="source">The source enumerable.</param>
	/// <param name="keySelector">A function to extract the key for each element.</param>
	/// <returns>A <c>Dictionary&lt;<typeparamref name="TKey"/>, List&lt;<typeparamref name="TValue"/>&gt;&gt;</c> where each dictionary entry represents a group.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> is null.</exception>
	public static Dictionary<TKey, List<TValue>> DictGroupByLists<TValue, TKey>(
		this IEnumerable<TValue> source, Func<TValue, TKey> keySelector
	) where TKey : notnull =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		keySelector == null ? throw new ArgumentNullException(nameof(keySelector)) :
		source.GroupBy(keySelector).ToDictionary(x => x.Key, x => x.ToList());

	/// <summary>
	/// Groups the elements of a sequence according to a specified key selector function and projects the resulting groups into a dictionary, with the elements of each group transformed using a specified function.
	/// </summary>
	/// <typeparam name="TValue">The type of elements of source.</typeparam>
	/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector"/>.</typeparam>
	/// <typeparam name="TResult">The type of the value returned by <paramref name="valueSelector"/>.</typeparam>
	/// <param name="source">The source enumerable.</param>
	/// <param name="keySelector">A function to extract the key for each element.</param>
	/// <param name="valueSelector">A transform function to apply to each group element</param>
	/// <returns>A <c>Dictionary&lt;<typeparamref name="TKey"/>, List&lt;<typeparamref name="TResult"/>&gt;&gt;</c> where each dictionary entry represents a group.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="keySelector"/> or <paramref name="valueSelector"/> is null.</exception>
	/// <remarks>The <paramref name="valueSelector"/> transform function is applied after grouping.</remarks>
	public static Dictionary<TKey, List<TResult>> DictGroupByLists<TValue, TKey, TResult>(
		this IEnumerable<TValue> source, Func<TValue, TKey> keySelector, Func<TValue, TResult> valueSelector
	) where TKey : notnull =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		keySelector == null ? throw new ArgumentNullException(nameof(keySelector)) :
		valueSelector == null ? throw new ArgumentNullException(nameof(valueSelector)) :
		source.GroupBy(keySelector).ToDictionary(x => x.Key, x => x.Select(valueSelector).ToList());

	/// <summary>
	/// Flattens the elements of nested enumerables into a single enumerable.
	/// </summary>
	/// <typeparam name="T">The type of elements of source.</typeparam>
	/// <param name="source">The source enumerable.</param>
	/// <returns>An <see cref="IEnumerable{T}"/> whose elements are the union of all source elements.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> source) =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		source.SelectMany(x => x);

	/// <summary>
	/// Randomises the order of the elements in the list using the Fisher-Yates algorithm.
	/// </summary>
	/// <typeparam name="T">The type of list elements.</typeparam>
	/// <param name="list">The list to be shuffled.</param>
	/// <remarks>Random numbers are generated on a thread-local basis using <see cref="DoubleSharp.Random.Rng"/>.</remarks>
	/// <exception cref="ArgumentNullException"><paramref name="list"/> is null.</exception>
	public static void Shuffle<T>(this IList<T> list) {
		if (list == null) throw new ArgumentNullException(nameof(list));
		if (!list.Any())
			return;
		var n = list.Count;
		while(n > 1) {
			n--;
			var k = Rng.Next(n + 1);
			(list[k], list[n]) = (list[n], list[k]);
		}
	}

	/// <summary>
	/// Generates a list containing the elements of a source sequence, in random order, without altering the source.
	/// </summary>
	/// <typeparam name="T">The type of elements of source.</typeparam>
	/// <param name="source">The source enumerable.</param>
	/// <remarks>
	/// <para>Shuffling is performed with the Fisher-Yates algorithm.</para>
	/// <para>Random numbers are generated on a thread-local basis using <see cref="DoubleSharp.Random.Rng"/>.</para>
	/// </remarks>
	/// <exception cref="ArgumentNullException"><paramref name="list"/> is null.</exception>
	public static List<T> Shuffled<T>(this IEnumerable<T> source) {
		if (source == null) throw new ArgumentNullException(nameof(source));
		var list = source.ToList();
		list.Shuffle();
		return list;
	}

	/// <summary>
	/// Returns the index of the maximum value in a sequence.
	/// </summary>
	/// <typeparam name="T">The type of elements of source</typeparam>
	/// <param name="source">The source collection.</param>
	/// <returns>The index of the element with the maximum value.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	/// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
	public static int IndexOfMax<T>(this ICollection<T> source) => IndexOfMax(source, null);

	/// <summary>
	/// Returns the index of the maximum value in a sequence.
	/// </summary>
	/// <typeparam name="T">The type of elements of source</typeparam>
	/// <param name="source">The source collection.</param>
	/// <param name="comparer">The <see cref="IComparer{T}"/> to compare values.</param>
	/// <returns>The index of the element with the maximum value.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	/// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
	public static int IndexOfMax<T>(this ICollection<T> source, IComparer<T>? comparer) =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		!source.Any() ? throw new InvalidOperationException("Sequence contains no elements.") :
		source.Enumerate().MaxBy(e => e.x, comparer).i;

	/// <summary>
	/// Returns the index of the maximum value in a sequence according to a specified key selector function.
	/// </summary>
	/// <typeparam name="TSource">The type of elements of source</typeparam>
	/// <param name="source">The source collection.</param>
	/// <param name="keySelector">A function to extract the key for each element.</param>
	/// <returns>The index of the element with the maximum value.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	/// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
	public static int IndexOfMaxBy<TSource, TKey>(this ICollection<TSource> source, Func<TSource, TKey> keySelector) => 
		IndexOfMaxBy(source, keySelector, null);

	/// <summary>
	/// Returns the index of the maximum value in a sequence according to a specified key selector function.
	/// </summary>
	/// <typeparam name="TSource">The type of elements of source</typeparam>
	/// <param name="source">The source collection.</param>
	/// <param name="keySelector">A function to extract the key for each element.</param>
	/// <param name="comparer">The <see cref="IComparer{T}"/> to compare values.</param>
	/// <returns>The index of the element with the maximum value.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	/// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
	public static int IndexOfMaxBy<TSource, TKey>(this ICollection<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer) =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		!source.Any() ? throw new InvalidOperationException("Sequence contains no elements.") :
		source.Enumerate().MaxBy(e => keySelector(e.x), comparer).i;

	/// <summary>
	/// Returns the index of the minimum value in a sequence.
	/// </summary>
	/// <typeparam name="T">The type of elements of source</typeparam>
	/// <param name="source">The source collection.</param>
	/// <returns>The index of the element with the minimum value.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	/// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
	public static int IndexOfMin<T>(this ICollection<T> source) => 
		IndexOfMin(source, null);

	/// <summary>
	/// Returns the index of the minimum value in a sequence.
	/// </summary>
	/// <typeparam name="T">The type of elements of source</typeparam>
	/// <param name="source">The source collection.</param>
	/// <param name="comparer">The <see cref="IComparer{T}"/> to compare values.</param>
	/// <returns>The index of the element with the minimum value.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	/// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
	public static int IndexOfMin<T>(this ICollection<T> source, IComparer<T>? comparer) =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		!source.Any() ? throw new InvalidOperationException("Sequence contains no elements.") :
		source.Enumerate().MinBy(e => e.x, comparer).i;

	/// <summary>
	/// Returns the index of the minimum value in a sequence according to a specified key selector function.
	/// </summary>
	/// <typeparam name="TSource">The type of elements of source</typeparam>
	/// <param name="source">The source collection.</param>
	/// <param name="keySelector">A function to extract the key for each element.</param>
	/// <returns>The index of the element with the minimum value.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	/// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
	public static int IndexOfMinBy<TSource, TKey>(this ICollection<TSource> source, Func<TSource, TKey> keySelector) => 
		IndexOfMinBy(source, keySelector, null);

	/// <summary>
	/// Returns the index of the minimum value in a sequence according to a specified key selector function.
	/// </summary>
	/// <typeparam name="TSource">The type of elements of source</typeparam>
	/// <param name="source">The source collection.</param>
	/// <param name="keySelector">A function to extract the key for each element.</param>
	/// <param name="comparer">The <see cref="IComparer{T}"/> to compare values.</param>
	/// <returns>The index of the element with the minimum value.</returns>
	/// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
	/// <exception cref="InvalidOperationException"><paramref name="source"/> contains no elements.</exception>
	public static int IndexOfMinBy<TSource, TKey>(this ICollection<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer) =>
		source == null ? throw new ArgumentNullException(nameof(source)) :
		!source.Any() ? throw new InvalidOperationException("Sequence contains no elements.") :
		source.Enumerate().MinBy(e => keySelector(e.x), comparer).i;

	/*
	 * The following ArgMin / ArgMax functions are aliases of the IndexOfMin(By)/IndexOfMax(By) functions above.
	 * These are provided to match the naming conventions in numpy & data science / ML contexts.
	 */

	/// <inheritdoc cref="IndexOfMax{T}(ICollection{T})" />
	/// <remarks>This is an alias of <see cref="IndexOfMax{T}(ICollection{T})"/></remarks>
	public static int ArgMax<T>(this ICollection<T> source) => 
		IndexOfMax<T>(source);

	/// <inheritdoc cref="IndexOfMax{T}(ICollection{T}, IComparer{T}?)" />
	/// <remarks>This is an alias of <see cref="IndexOfMax{T}(ICollection{T}, IComparer{T}?)"/></remarks>
	public static int ArgMax<T>(this ICollection<T> source, IComparer<T>? comparer) => 
		IndexOfMax<T>(source, comparer);

	/// <inheritdoc cref="IndexOfMaxBy{TSource, TKey}(ICollection{TSource}, Func{TSource, TKey}))" />
	/// <remarks>This is an alias of <see cref="IndexOfMaxBy{TSource, TKey}(ICollection{TSource}, Func{TSource, TKey})"/></remarks>
	public static int ArgMax<TSource, TKey>(this ICollection<TSource> source, Func<TSource, TKey> keySelector) => 
		IndexOfMaxBy<TSource, TKey>(source, keySelector);

	/// <inheritdoc cref="IndexOfMaxBy{TSource, TKey}(ICollection{TSource}, Func{TSource, TKey}, IComparer{TKey}?)"/>
	/// <remarks>This is an alias of <see cref="IndexOfMaxBy{TSource, TKey}(ICollection{TSource}, Func{TSource, TKey}, IComparer{TKey}?)"/></remarks>
	public static int ArgMax<TSource, TKey>(this ICollection<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer) => 
		IndexOfMaxBy<TSource, TKey>(source, keySelector, comparer);

	/// <inheritdoc cref="IndexOfMin{T}(ICollection{T})" />
	/// <remarks>This is an alias of <see cref="IndexOfMin{T}(ICollection{T})"/></remarks>
	public static int ArgMin<T>(this ICollection<T> source) =>
		IndexOfMin<T>(source);

	/// <inheritdoc cref="IndexOfMin{T}(ICollection{T}, IComparer{T}?)" />
	/// <remarks>This is an alias of <see cref="IndexOfMin{T}(ICollection{T}, IComparer{T}?)"/></remarks>
	public static int ArgMin<T>(this ICollection<T> source, IComparer<T>? comparer) =>
		IndexOfMin<T>(source, comparer);

	/// <inheritdoc cref="IndexOfMinBy{TSource, TKey}(ICollection{TSource}, Func{TSource, TKey}))" />
	/// <remarks>This is an alias of <see cref="IndexOfMinBy{TSource, TKey}(ICollection{TSource}, Func{TSource, TKey})"/></remarks>
	public static int ArgMin<TSource, TKey>(this ICollection<TSource> source, Func<TSource, TKey> keySelector) =>
		IndexOfMinBy<TSource, TKey>(source, keySelector);

	/// <inheritdoc cref="IndexOfMinBy{TSource, TKey}(ICollection{TSource}, Func{TSource, TKey}, IComparer{TKey}?)"/>
	/// <remarks>This is an alias of <see cref="IndexOfMinBy{TSource, TKey}(ICollection{TSource}, Func{TSource, TKey}, IComparer{TKey}?)"/></remarks>
	public static int ArgMin<TSource, TKey>(this ICollection<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer) =>
		IndexOfMinBy<TSource, TKey>(source, keySelector, comparer);

	public static T Median<T>(this IEnumerable<T> source) where T : INumber<T> {
		var sorted = source.Order().ToList();
		var midpoint = sorted.Count / 2;
		if(sorted.Count % 2 != 0) return sorted[midpoint];
		var a = sorted[midpoint - 1];
		var b = sorted[midpoint];
		return (a + b) / T.CreateChecked(2);
	}
	
	// WARNING: This will always return the lower end of the median if it's an even-lengthed sequence
	public static TValue MedianBy<TValue, TKey>(this IEnumerable<TValue> source, Func<TValue, TKey> by) {
		var sorted = source.OrderBy(by).ToList();
		var midpoint = sorted.Count / 2;
		return sorted[midpoint];
	}
	
	public static IEnumerable<int> Range(this int end) =>
		Enumerable.Range(0, end);
	public static IEnumerable<int> Range(this (int Start, int End) range) =>
		Enumerable.Range(range.Start, range.End - range.Start);
	public static IEnumerable<int> Range(this (int Start, int End, int Step) range) {
		for(var i = range.Start; i < range.End; i += range.Step)
			yield return i;
	}

	public static void Times(this int count, Action functor) {
		for(var i = 0; i < count; ++i)
			functor();
	}
	public static void Times(this int count, Action<int> functor) {
		for(var i = 0; i < count; ++i)
			functor(i);
	}

	// If you accidentally make your functor return a value when you wanted to
	// use the above Action instances instead, the Pure attribute throws a warning.
	// Basically, it adds a small safety to the footgun.
	[Pure]
	public static IEnumerable<T> Times<T>(this int count, Func<T> functor) =>
		count.Range().Select(_ => functor());
	[Pure]
	public static IEnumerable<T> Times<T>(this int count, Func<int, T> functor) =>
		count.Range().Select(functor);

    /// <summary>
    /// Gets an array of <see cref="Type"/> objects representing the types of the tuple components.
    /// </summary>
    /// <param name="tuple">The tuple.</param>
    /// <returns>An array of <see cref="Type"/> objects representing the types of the tuple components.</returns>
    public static Type[] GetComponentTypes(this ITuple tuple) =>
	    tuple.GetType().GetGenericArguments();

    /// <summary>
    /// Enumerates the components of a tuple where the component type is compatible with <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of components to enumerate.</typeparam>
    /// <param name="tuple">The tuple to enumerate.</param>
    /// <returns>
    /// <para>An <see cref="IEnumerable{T}"/> containing all components from the tuple whose type was compatible with <typeparamref name="T"/>.</para>
    /// <para>If <paramref name="tuple"/> is null, no elements are returned.</para>
    /// </returns>
    public static IEnumerable<T> EnumerateComponents<T>(this ITuple? tuple) {
        if(tuple == null)
            yield break;
        var t = tuple.GetComponentTypes();
        for(var n = 0; n < tuple.Length; n++)
            if(t[n].IsAssignableTo(typeof(T)))
                yield return (T) tuple[n]!;
    }

    /// <summary>
    /// Enumerates the components of a tuple.
    /// </summary>
    /// <param name="tuple"></param>
    /// <returns></returns>
    public static IEnumerable<object?> EnumerateComponents(this ITuple tuple) =>
	    EnumerateComponents<object>(tuple);
}
