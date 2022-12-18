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
		Assert.That(count1.Increment(), Is.EqualTo(10001));
		var count2 = 0U;
		Parallel.For(0, 10000, _ => count2.Increment());
		Assert.That(count2, Is.EqualTo(10000U));
		Assert.That(count2.Increment(), Is.EqualTo(10001U));
		var count3 = 0L;
		Parallel.For(0, 10000, _ => count3.Increment());
		Assert.That(count3, Is.EqualTo(10000L));
		Assert.That(count3.Increment(), Is.EqualTo(10001L));
		var count4 = 0UL;
		Parallel.For(0, 10000, _ => count4.Increment());
		Assert.That(count4, Is.EqualTo(10000UL));
		Assert.That(count4.Increment(), Is.EqualTo(10001UL));
	}
	
	[Test]
	public void Decrement() {
		var count1 = 10001;
		Assert.That(count1.Decrement(), Is.EqualTo(10000));
		Parallel.For(0, 10000, _ => count1.Decrement());
		Assert.That(count1, Is.EqualTo(0));
		var count2 = 10001U;
		Assert.That(count2.Decrement(), Is.EqualTo(10000U));
		Parallel.For(0, 10000, _ => count2.Decrement());
		Assert.That(count2, Is.EqualTo(0U));
		var count3 = 10001L;
		Assert.That(count3.Decrement(), Is.EqualTo(10000L));
		Parallel.For(0, 10000, _ => count3.Decrement());
		Assert.That(count3, Is.EqualTo(0L));
		var count4 = 10001UL;
		Assert.That(count4.Decrement(), Is.EqualTo(10000UL));
		Parallel.For(0, 10000, _ => count4.Decrement());
		Assert.That(count4, Is.EqualTo(0UL));
	}

	[Test]
	public void Add() {
		var count1 = 0;
		Parallel.For(0, 10000, _ => count1.Add(3));
		Assert.That(count1, Is.EqualTo(30000));
		Assert.That(count1.Add(5), Is.EqualTo(30005));
		var count2 = 0U;
		Parallel.For(0, 10000, _ => count2.Add(3U));
		Assert.That(count2, Is.EqualTo(30000));
		Assert.That(count2.Add(5U), Is.EqualTo(30005U));
		var count3 = 0L;
		Parallel.For(0, 10000, _ => count3.Add(3L));
		Assert.That(count3, Is.EqualTo(30000L));
		Assert.That(count3.Add(5L), Is.EqualTo(30005L));
		var count4 = 0UL;
		Parallel.For(0, 10000, _ => count4.Add(3UL));
		Assert.That(count4, Is.EqualTo(30000UL));
		Assert.That(count4.Add(5UL), Is.EqualTo(30005UL));
	}
}