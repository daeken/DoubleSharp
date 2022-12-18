using System.Collections.Concurrent;
using DoubleSharp.Concurrency;
using NUnit.Framework;

namespace Tests; 

[TestFixture]
public class ConcurrencyTests {
	[Test]
	public void Locked() {
		var foo = "foB";
		var count = 0;
		Parallel.For(0, 10000, _ => foo.Locked(() => count++));
		Assert.That(count, Is.EqualTo(10000));
		var comb = "";
		Parallel.For(0, 1000, _ => foo.Locked(x => comb += x));
		Assert.That(comb, Is.EqualTo(string.Concat(Enumerable.Repeat(foo, 1000))));
	}
	
	[Test]
	public void Increment() {
		var count1 = 0;
		Parallel.For(0, 10000, _ => count1.Increment());
		Assert.That(count1, Is.EqualTo(10000));
		var count2 = 0U;
		Parallel.For(0, 10000, _ => count2.Increment());
		Assert.That(count2, Is.EqualTo(10000U));
		var count3 = 0L;
		Parallel.For(0, 10000, _ => count3.Increment());
		Assert.That(count3, Is.EqualTo(10000L));
		var count4 = 0UL;
		Parallel.For(0, 10000, _ => count4.Increment());
		Assert.That(count4, Is.EqualTo(10000UL));
	}
	
	[Test]
	public void Decrement() {
		var count1 = 10000;
		Parallel.For(0, 10000, _ => count1.Decrement());
		Assert.That(count1, Is.EqualTo(0));
		var count2 = 10000U;
		Parallel.For(0, 10000, _ => count2.Decrement());
		Assert.That(count2, Is.EqualTo(0U));
		var count3 = 10000L;
		Parallel.For(0, 10000, _ => count3.Decrement());
		Assert.That(count3, Is.EqualTo(0L));
		var count4 = 10000UL;
		Parallel.For(0, 10000, _ => count4.Decrement());
		Assert.That(count4, Is.EqualTo(0UL));
	}
}