using System.Diagnostics.CodeAnalysis;

namespace DoubleSharp.Progress;

using System.Diagnostics;

/// <summary>DoubleSharp progress bar extensions.</summary>
[ExcludeFromCodeCoverage]
public static class ProgressExtensions {

    /// <summary>
    /// Creates an <see cref="IEnumerable{T}"/> that enumerates through elements of a sequence and prints a progress bar to the <see cref="Console"/>.
    /// </summary>
    /// <typeparam name="T">Type of elements of source.</typeparam>
    /// <param name="source">The source enumerable.</param>
    /// <param name="count">The count of elements in <paramref name="source"/>. If null, the the progress bar will display the progress as unknown.</param>
    /// <param name="constantUpdate">If true, prints a new progress line every time a new element is processed. Otherwise, new progress lines are only printed when an additional "notch" of progress has been reached.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> containing the elements of source enumerable.</returns>
    public static IEnumerable<T> WithProgress<T>(this IEnumerable<T> source, int? count = null, bool constantUpdate = false) =>
		Progress(source, count, constantUpdate);

    /// <summary>
    /// Creates an <see cref="IEnumerable{T}"/> that enumerates through elements of a sequence and prints a progress bar to the <see cref="Console"/>.
    /// </summary>
    /// <typeparam name="T">Type of elements of source.</typeparam>
    /// <param name="source">The source collection.</param>
    /// <param name="constantUpdate">If true, prints a new progress line every time a new element is processed. Otherwise, new progress lines are only printed when an additional "notch" of progress has been reached.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> containing the elements of source enumerable.</returns>
    public static IEnumerable<T> WithProgress<T>(this ICollection<T> source, bool constantUpdate = false) =>
		source.WithProgress(source.Count, constantUpdate);

	static IEnumerable<T> Progress<T>(IEnumerable<T> query, int? count, bool constantUpdate) {
		var size = Math.Min(33, count ?? 1);
		var counter = 0;
		var div = (count ?? 0) / size;
		foreach(var elem in query) {
			yield return elem;
			counter++;
			if(div == 0 || count == null) {
				Console.Write($"\r{counter}/{(count == null ? "unknown" : count)}");
				continue;
			}
			if(!constantUpdate && counter % div != 1)
				continue;
			var numStars = Math.Min(counter / div, size);
			Console.Write($"\r|{new('*', numStars)}{new('-', size - numStars)}| {counter}/{count}");
		}
		if(count == null)
			Console.WriteLine($"\r{counter}/{counter}{new(' ', 8)}");
		else
			Console.WriteLine($"\r|{new('*', size)}| {counter}/{count}");
	}

    /// <summary>
    /// Creates an <see cref="IEnumerable{T}"/> that enumerates through elements of a sequence and prints a progress bar to the <see cref="Console"/>, showing the elapsed time and the estimated remaining time.
    /// </summary>
    /// <typeparam name="T">Type of elements of source.</typeparam>
    /// <param name="source">The source enumerable.</param>
    /// <param name="count">The count of elements in <paramref name="source"/>. If null, the the progress bar will display the progress as unknown.</param>
    /// <param name="constantUpdate">If true, prints a new progress line every time a new element is processed. Otherwise, new progress lines are only printed when an additional "notch" of progress has been reached.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> containing the elements of source enumerable.</returns>
    public static IEnumerable<T> WithTimedProgress<T>(this IEnumerable<T> source, int count, bool constantUpdate = false) =>
		TimedProgress(source, count, constantUpdate);

    /// <summary>
    /// Creates an <see cref="IEnumerable{T}"/> that enumerates through elements of a sequence and prints a progress bar to the <see cref="Console"/>, showing the elapsed time and the estimated remaining time.
    /// </summary>
    /// <typeparam name="T">Type of elements of source.</typeparam>
    /// <param name="source">The source enumerable.</param>
    /// <param name="constantUpdate">If true, prints a new progress line every time a new element is processed. Otherwise, new progress lines are only printed when an additional "notch" of progress has been reached.</param>
    /// <returns>An <see cref="IEnumerable{T}"/> containing the elements of source enumerable.</returns>
    public static IEnumerable<T> WithTimedProgress<T>(this ICollection<T> source, bool constantUpdate = false) =>
		source.WithTimedProgress(source.Count, constantUpdate);

	static IEnumerable<T> TimedProgress<T>(IEnumerable<T> source, int count, bool constantUpdate) {
		var size = Math.Min(33, count);
		var counter = 0;
		var div = count == size ? 1 : count / size;
		var sw = new Stopwatch();
		sw.Start();

		string Time() {
			string Format(long ticks) {
				var subSecond = ticks % Stopwatch.Frequency;
				var ms = (int) ((double) subSecond / Stopwatch.Frequency * 1000);
				var seconds = ticks / Stopwatch.Frequency;
				var minutes = seconds / 60;
				var hours = minutes / 60;
				return hours > 0
					? $"{hours}:{minutes % 60:D2}:{seconds % 60:D2}.{ms:D3}"
					: $"{minutes:D2}:{seconds % 60:D2}.{ms:D3}";
			}
			
			var ticks = sw.ElapsedTicks;
			var ticksPerElem = (double) ticks / counter;
			if(counter == count)
				return $"{Format(ticks)} elapsed ({Format((long) ticksPerElem)} per iteration)";
			var estimate = ticksPerElem * (count - counter);
			return $"{Format(ticks)} elapsed, {Format((long) estimate)} remaining ({Format((long) ticksPerElem)} per iteration)";
		}
		
		foreach(var elem in source) {
			yield return elem;
			counter++;
			if(!constantUpdate && counter % div != 1)
				continue;
			var numStars = Math.Min(counter / div, size);
			Console.Write($"\r|{new('*', numStars)}{new('-', size - numStars)}| {counter}/{count} -- {Time()}");
		}
		Console.WriteLine($"\r|{new('*', size)}| {counter}/{count} -- {Time()}{new(' ', 24)}");
	}
}