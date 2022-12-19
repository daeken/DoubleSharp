using DoubleSharp.Linq;
using DoubleSharp.Random;

namespace Tests; 

#pragma warning disable NUnit2009
[TestFixture]
public class RandomTests {
	[Test]
	public void Next() {
		Assert.Multiple(() => {
			Assert.That(100.Times(_ => Rng.Next()), Is.Not.EquivalentTo(100.Times(_ => Rng.Next())));
			Assert.That(100.Times(_ => Rng.Next(500)), Is.Not.EquivalentTo(100.Times(_ => Rng.Next(500))));
			Assert.That(100.Times(_ => Rng.Next(1, 500)), Is.Not.EquivalentTo(100.Times(_ => Rng.Next(1, 500))));
			Assert.That(() => Rng.Next(500, 1), Throws.InstanceOf<ArgumentOutOfRangeException>());
			Assert.That(() => Rng.Next(-100), Throws.InstanceOf<ArgumentOutOfRangeException>());
		});
	}

	[Test]
	public void NextInt64() {
		Assert.Multiple(() => {
			Assert.That(100.Times(_ => Rng.NextInt64()), Is.Not.EquivalentTo(100.Times(_ => Rng.NextInt64())));
			Assert.That(100.Times(_ => Rng.NextInt64(500)), Is.Not.EquivalentTo(100.Times(_ => Rng.NextInt64(500))));
			Assert.That(100.Times(_ => Rng.NextInt64(1, 500)), Is.Not.EquivalentTo(100.Times(_ => Rng.NextInt64(1, 500))));
			Assert.That(() => Rng.NextInt64(500, 1), Throws.InstanceOf<ArgumentOutOfRangeException>());
			Assert.That(() => Rng.NextInt64(-100), Throws.InstanceOf<ArgumentOutOfRangeException>());
		});
	}

	[Test]
	public void NextSingle() =>
		Assert.That(100.Times(_ => Rng.NextSingle()), Is.Not.EquivalentTo(100.Times(_ => Rng.NextSingle())));
	
	[Test]
	public void NextDouble() =>
		Assert.That(100.Times(_ => Rng.NextDouble()), Is.Not.EquivalentTo(100.Times(_ => Rng.NextDouble())));

	[Test]
	public void NextBytes() {
		Assert.Multiple(() => {
			Assert.That(() => Rng.NextBytes(null), Throws.ArgumentNullException);
			
			var buf1 = new byte[100];
			var buf2 = new byte[100];
			Rng.NextBytes(buf1);
			Rng.NextBytes(buf2);
			Assert.That(buf1, Is.Not.EquivalentTo(buf2));
			
			Span<byte> span1 = stackalloc byte[100];
			Span<byte> span2 = stackalloc byte[100];
			Rng.NextBytes(span1);
			Rng.NextBytes(span2);
			Assert.That(span1.ToArray(), Is.Not.EquivalentTo(span2.ToArray()));
		});
	}
}
#pragma warning restore NUnit2009