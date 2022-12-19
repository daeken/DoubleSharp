using System.Numerics;
using DoubleSharp.MathPlus;

namespace Tests; 

[TestFixture]
public class VectorTests {
	[Test]
	public void Deconstruct() {
		Assert.Multiple(() => {
			var (x, y, z, w) = new Vector4(4, 5, 6, 7);
			Assert.That((x, y, z, w), Is.EqualTo((4f, 5f, 6f, 7f)));
			(x, y, z) = new Vector3(5, 6, 7);
			Assert.That((x, y, z), Is.EqualTo((5f, 6f, 7f)));
			(x, y) = new Vector2(6, 7);
			Assert.That((x, y), Is.EqualTo((6f, 7f)));
		});
	}
	
	[Test]
	public void ToVector() {
		Assert.Multiple(() => {
			Assert.That((6f, 7f).ToVector(), Is.EqualTo(new Vector2(6f, 7f)));
			Assert.That((5f, 6f, 7f).ToVector(), Is.EqualTo(new Vector3(5f, 6f, 7f)));
			Assert.That((4f, 5f, 6f, 7f).ToVector(), Is.EqualTo(new Vector4(4f, 5f, 6f, 7f)));
			
			Assert.That((6, 7).ToVector(), Is.EqualTo(new Vector2(6f, 7f)));
			Assert.That((5, 6, 7).ToVector(), Is.EqualTo(new Vector3(5f, 6f, 7f)));
			Assert.That((4, 5, 6, 7).ToVector(), Is.EqualTo(new Vector4(4f, 5f, 6f, 7f)));
		});
	}
	
	[Test]
	public void Map() {
		Assert.Multiple(() => {
			Assert.That(new Vector2(6f, 7f).Map(x => x * 2), Is.EqualTo(new Vector2(12f, 14f)));
			Assert.That(new Vector3(5f, 6f, 7f).Map(x => x * 2), Is.EqualTo(new Vector3(10f, 12f, 14f)));
			Assert.That(new Vector4(4f, 5f, 6f, 7f).Map(x => x * 2), Is.EqualTo(new Vector4(8f, 10f, 12f, 14f)));
		});
	}
	
	[Test]
	public void Normalize() {
		Assert.Multiple(() => {
			Assert.That(new Vector2(6f, 7f).Normalize(), Is.EqualTo(Vector2.Normalize(new(6f, 7f))));
			Assert.That(new Vector3(5f, 6f, 7f).Normalize(), Is.EqualTo(Vector3.Normalize(new(5f, 6f, 7f))));
			Assert.That(new Vector4(4f, 5f, 6f, 7f).Normalize(), Is.EqualTo(Vector4.Normalize(new(4f, 5f, 6f, 7f))));
		});
	}
	
	[Test]
	public void Abs() {
		Assert.Multiple(() => {
			Assert.That(new Vector2(6f, 7f).Abs(), Is.EqualTo(new Vector2(6f, 7f)));
			Assert.That(new Vector3(5f, 6f, 7f).Abs(), Is.EqualTo(new Vector3(5f, 6f, 7f)));
			Assert.That(new Vector4(4f, 5f, 6f, 7f).Abs(), Is.EqualTo(new Vector4(4f, 5f, 6f, 7f)));
			
			Assert.That(new Vector2(-6f, 7f).Abs(), Is.EqualTo(new Vector2(6f, 7f)));
			Assert.That(new Vector3(-5f, 6f, 7f).Abs(), Is.EqualTo(new Vector3(5f, 6f, 7f)));
			Assert.That(new Vector4(-4f, 5f, 6f, 7f).Abs(), Is.EqualTo(new Vector4(4f, 5f, 6f, 7f)));
			
			Assert.That(new Vector2(6f, -7f).Abs(), Is.EqualTo(new Vector2(6f, 7f)));
			Assert.That(new Vector3(5f, -6f, 7f).Abs(), Is.EqualTo(new Vector3(5f, 6f, 7f)));
			Assert.That(new Vector4(4f, -5f, 6f, 7f).Abs(), Is.EqualTo(new Vector4(4f, 5f, 6f, 7f)));
			
			Assert.That(new Vector3(5f, 6f, -7f).Abs(), Is.EqualTo(new Vector3(5f, 6f, 7f)));
			Assert.That(new Vector4(4f, 5f, -6f, 7f).Abs(), Is.EqualTo(new Vector4(4f, 5f, 6f, 7f)));
			
			Assert.That(new Vector4(4f, 5f, 6f, -7f).Abs(), Is.EqualTo(new Vector4(4f, 5f, 6f, 7f)));
			
			Assert.That(new Vector2(-6f, -7f).Abs(), Is.EqualTo(new Vector2(6f, 7f)));
			Assert.That(new Vector3(-5f, -6f, -7f).Abs(), Is.EqualTo(new Vector3(5f, 6f, 7f)));
			Assert.That(new Vector4(-4f, -5f, -6f, -7f).Abs(), Is.EqualTo(new Vector4(4f, 5f, 6f, 7f)));
		});
	}
	
	[Test]
	public void Cross() {
		Assert.Multiple(() => {
			Assert.That(new Vector2(1f, 0f).Cross(new(0, 1)), Is.EqualTo(1));
			Assert.That(new Vector2(1f, 1f).Cross(new(0, 1)), Is.EqualTo(1));
			Assert.That(new Vector2(0f, 1f).Cross(new(0, 1)), Is.EqualTo(0));
			Assert.That(new Vector2(0f, 0f).Cross(new(1, 0)), Is.EqualTo(0));
		});
	}
	
	[Test]
	public void Min() {
		Assert.Multiple(() => {
			Assert.That(new Vector2(0f, 5f).Min(new(6f, 1f)), Is.EqualTo(new Vector2(0f, 1f)));
			Assert.That(new Vector3(0f, 5f, 4f).Min(new(6f, 1f, 3f)), Is.EqualTo(new Vector3(0f, 1f, 3f)));
			Assert.That(new Vector4(0f, 5f, 4f, 2f).Min(new(6f, 1f, 3f, 7f)), Is.EqualTo(new Vector4(0f, 1f, 3f, 2f)));
		});
	}
	
	[Test]
	public void Max() {
		Assert.Multiple(() => {
			Assert.That(new Vector2(0f, 5f).Max(new(6f, 1f)), Is.EqualTo(new Vector2(6f, 5f)));
			Assert.That(new Vector3(0f, 5f, 4f).Max(new(6f, 1f, 3f)), Is.EqualTo(new Vector3(6f, 5f, 4f)));
			Assert.That(new Vector4(0f, 5f, 4f, 2f).Max(new(6f, 1f, 3f, 7f)), Is.EqualTo(new Vector4(6f, 5f, 4f, 7f)));
		});
	}
	
	[Test]
	public void Rotate() {
		Assert.Multiple(() => {
			var vec = Vector2.UnitX;
			vec = vec.Rotate(MathF.Tau);
			Assert.That(Vector2.Distance(vec, Vector2.UnitX), Is.LessThan(0.0001f)); // Gotta love approximations
			vec = vec.Rotate(MathF.Tau / 4);
			Assert.That(Vector2.Distance(vec, Vector2.UnitY), Is.LessThan(0.0001f));
			vec = vec.Rotate(MathF.Tau / 2);
			Assert.That(Vector2.Distance(vec, -Vector2.UnitY), Is.LessThan(0.0001f));
			vec = vec.Rotate(MathF.Tau / 8);
			vec = vec.Rotate(MathF.Tau / 8);
			Assert.That(Vector2.Distance(vec, Vector2.UnitX), Is.LessThan(0.0001f));
		});
	}

	[Test]
	public void Centroid2() {
		Assert.Multiple(() => {
			var a = new Vector2(1, 1);
			var b = new Vector2(-1, -1);
			var c = new Vector2(1, -1);
			var d = new Vector2(-1, 1);
			
			Assert.That(Enumerable.Empty<Vector2>().Centroid(), Is.EqualTo(Vector2.Zero));
			Assert.That(Vector2.Distance(new[] { a }.Centroid(), a), Is.LessThan(0.0001f));
			Assert.That(Vector2.Distance(new[] { a, b }.Centroid(), Vector2.Zero), Is.LessThan(0.0001f));
			Assert.That(Vector2.Distance(new[] { a, b, c, d }.Centroid(), Vector2.Zero), Is.LessThan(0.0001f));
			Assert.That(Vector2.Distance(Enumerable.Repeat(a, 10000).Centroid(), a), Is.LessThan(0.0001f));
		});
	}

	[Test]
	public void Centroid3() {
		Assert.Multiple(() => {
			var a = new Vector3(1, 0, 1);
			var b = new Vector3(-1, 0, -1);
			var c = new Vector3(0, 1, -1);
			var d = new Vector3(0, -1, 1);
			
			Assert.That(Enumerable.Empty<Vector3>().Centroid(), Is.EqualTo(Vector3.Zero));
			Assert.That(Vector3.Distance(new[] { a }.Centroid(), a), Is.LessThan(0.0001f));
			Assert.That(Vector3.Distance(new[] { a, b }.Centroid(), Vector3.Zero), Is.LessThan(0.0001f));
			Assert.That(Vector3.Distance(new[] { a, b, c, d }.Centroid(), Vector3.Zero), Is.LessThan(0.0001f));
			Assert.That(Vector3.Distance(Enumerable.Repeat(a, 10000).Centroid(), a), Is.LessThan(0.0001f));
		});
	}

	[Test]
	public void Centroid4() {
		Assert.Multiple(() => {
			var a = new Vector4(0, 1, 0, 1);
			var b = new Vector4(0, -1, 0, -1);
			var c = new Vector4(0, 1, 0, -1);
			var d = new Vector4(0, -1, 0, 1);
			
			Assert.That(Enumerable.Empty<Vector4>().Centroid(), Is.EqualTo(Vector4.Zero));
			Assert.That(Vector4.Distance(new[] { a }.Centroid(), a), Is.LessThan(0.0001f));
			Assert.That(Vector4.Distance(new[] { a, b }.Centroid(), Vector4.Zero), Is.LessThan(0.0001f));
			Assert.That(Vector4.Distance(new[] { a, b, c, d }.Centroid(), Vector4.Zero), Is.LessThan(0.0001f));
			Assert.That(Vector4.Distance(Enumerable.Repeat(a, 10000).Centroid(), a), Is.LessThan(0.0001f));
		});
	}
}