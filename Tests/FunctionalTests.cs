using DoubleSharp.Functional;
using NUnit.Framework;

namespace Tests; 

[TestFixture]
public class FunctionalTests {
	[Test]
	public void Compose() {
		var square = (int x) => (long) x * x;
		double AddFive(long x) => (double) x + 5;

		var func = square.Compose(AddFive);
		Assert.That(func(3), Is.EqualTo(14));
	}
}