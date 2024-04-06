using DoubleSharp.MathPlus;

namespace Tests; 

[TestFixture]
public class MathTests {
	[Test]
	public void Round() {
		Assert.Multiple(() => {
			Assert.That(6.3f.Round(), Is.EqualTo(6f));
			Assert.That(6.7f.Round(), Is.EqualTo(7f));
			Assert.That(6.3.Round(), Is.EqualTo(6.0));
			Assert.That(6.7.Round(), Is.EqualTo(7.0));
		});
	}
	
	[Test]
	public void RoundInt() {
		Assert.Multiple(() => {
			Assert.That(6.3f.RoundInt(), Is.EqualTo(6));
			Assert.That(6.7f.RoundInt(), Is.EqualTo(7));
			Assert.That(6.3.RoundInt(), Is.EqualTo(6));
			Assert.That(6.7.RoundInt(), Is.EqualTo(7));
		});
	}
	
	[Test]
	public void Floor() {
		Assert.Multiple(() => {
			Assert.That(6.3f.Floor(), Is.EqualTo(6f));
			Assert.That(6.7f.Floor(), Is.EqualTo(6f));
			Assert.That(6.3.Floor(), Is.EqualTo(6.0));
			Assert.That(6.7.Floor(), Is.EqualTo(6.0));
		});
	}
	
	[Test]
	public void FloorInt() {
		Assert.Multiple(() => {
			Assert.That(6.3f.FloorInt(), Is.EqualTo(6));
			Assert.That(6.7f.FloorInt(), Is.EqualTo(6));
			Assert.That(6.3.FloorInt(), Is.EqualTo(6));
			Assert.That(6.7.FloorInt(), Is.EqualTo(6));
		});
	}
	
	[Test]
	public void Ceil() {
		Assert.Multiple(() => {
			Assert.That(6.3f.Ceil(), Is.EqualTo(7f));
			Assert.That(6.7f.Ceil(), Is.EqualTo(7f));
			Assert.That(6.3.Ceil(), Is.EqualTo(7.0));
			Assert.That(6.7.Ceil(), Is.EqualTo(7.0));
		});
	}
	
	[Test]
	public void CeilInt() {
		Assert.Multiple(() => {
			Assert.That(6.3f.CeilInt(), Is.EqualTo(7));
			Assert.That(6.7f.CeilInt(), Is.EqualTo(7));
			Assert.That(6.3.CeilInt(), Is.EqualTo(7));
			Assert.That(6.7.CeilInt(), Is.EqualTo(7));
		});
	}

	[Test]
	public void Lerp() {
		Assert.Multiple(() => {
			Assert.That(0f.Lerp(1f, 0), Is.EqualTo(0f));
			Assert.That(0f.Lerp(1f, 1), Is.EqualTo(1f));
			Assert.That(0f.Lerp(1f, 0.5f), Is.EqualTo(0.5f));
			Assert.That(1f.Lerp(0f, 0), Is.EqualTo(1f));
			Assert.That(1f.Lerp(0f, 1), Is.EqualTo(0f));
			Assert.That(1f.Lerp(0f, 0.5f), Is.EqualTo(0.5f));
			Assert.That(1f.Lerp(5f, 0), Is.EqualTo(1f));
			Assert.That(1f.Lerp(5f, 1), Is.EqualTo(5f));
			Assert.That(1f.Lerp(5f, 0.5f), Is.EqualTo(3f));
			
			Assert.That(0.0.Lerp(1, 0), Is.EqualTo(0));
			Assert.That(0.0.Lerp(1, 1), Is.EqualTo(1));
			Assert.That(0.0.Lerp(1, 0.5), Is.EqualTo(0.5));
			Assert.That(1.0.Lerp(0, 0), Is.EqualTo(1));
			Assert.That(1.0.Lerp(0, 1), Is.EqualTo(0));
			Assert.That(1.0.Lerp(0, 0.5), Is.EqualTo(0.5));
			Assert.That(1.0.Lerp(5, 0), Is.EqualTo(1));
			Assert.That(1.0.Lerp(5, 1), Is.EqualTo(5));
			Assert.That(1.0.Lerp(5, 0.5), Is.EqualTo(3));
		});
	}
}