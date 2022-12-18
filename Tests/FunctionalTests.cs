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
	
	[Test]
	public void Compose2() {
		var square = (int x) => (long) x * x;
		int Halve(long x) => (int) (x / 2);
		double AddFive(int x) => (double) x + 5;

		var func = square.Compose(Halve, AddFive);
		Assert.That(func(10), Is.EqualTo(55));
	}
}