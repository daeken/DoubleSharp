using DoubleSharp.Functional;

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

	[Test]
	public void ComposeAll() {
		Func<uint, uint> func0 = i => (i << 4) | 1U;
		Func<uint, uint> func1 = i => (i << 4) | 2U;
		Func<uint, uint> func2 = i => (i << 4) | 3U;
		Func<uint, uint> func3 = i => (i << 4) | 4U;
		Func<uint, uint> func4 = i => (i << 4) | 5U;
		Func<uint, uint> func5 = i => (i << 4) | 6U;
		Func<uint, uint> func6 = i => (i << 4) | 7U;
		Func<uint, uint> func7 = i => (i << 4) | 8U;
		
		Assert.Multiple(() => {
			Assert.That(func0.Compose(func1)(0U), Is.EqualTo(0x00000012U));
			Assert.That(func0.Compose(func1, func2)(0U), Is.EqualTo(0x00000123U));
			Assert.That(func0.Compose(func1, func2, func3)(0U), Is.EqualTo(0x00001234U));
			Assert.That(func0.Compose(func1, func2, func3, func4)(0U), Is.EqualTo(0x00012345U));
			Assert.That(func0.Compose(func1, func2, func3, func4, func5)(0U), Is.EqualTo(0x00123456U));
			Assert.That(func0.Compose(func1, func2, func3, func4, func5, func6)(0U), Is.EqualTo(0x01234567U));
			Assert.That(func0.Compose(func1, func2, func3, func4, func5, func6, func7)(0U), Is.EqualTo(0x12345678U));
		});
	}
}