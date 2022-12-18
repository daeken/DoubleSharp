using System.Collections.Concurrent;
using DoubleSharp.Linq;

namespace Tests;

public class LinqTests {
	[Test]
	public void Enumerate() {
		foreach(var (i, x) in Enumerable.Range(0, 1000).Enumerate())
			Assert.That(x, Is.EqualTo(i));
	}

	[Test]
	public void ToDictionary() {
		var data = new[] {
			("Alice", 10), 
			("Bob", 5),
			("Charlie", 8),
		};
		var dict = data.ToDictionary();
		foreach(var (name, rank) in data)
			Assert.That(rank, Is.EqualTo(dict[name]));
	}

	[Test]
	public void ForEach() {
		var sum = 0;
		Enumerable.Range(0, 1000).ForEach(i => sum += i);
		Assert.That(sum, Is.EqualTo(499500));
		var coll = new ConcurrentBag<int>();
		Enumerable.Range(0, 1000).AsParallel().ForEach(i => coll.Add(i));
		Assert.That(coll.Sum(), Is.EqualTo(499500));
	}
}