using System.Numerics;

namespace DoubleSharp.MathPlus; 

/// <summary>DoubleSharp vector extensions.</summary>
public static class VectorExtensions {
	/// <summary>
	/// Deconstructs the elements of a Vector2. 
	/// </summary>
	/// <param name="vec">The input Vector2.</param>
	/// <param name="x">The output X element.</param>
	/// <param name="y">The output Y element.</param>
	public static void Deconstruct(this Vector2 vec, out float x, out float y) =>
		(x, y) = (vec.X, vec.Y);
	/// <summary>
	/// Deconstructs the elements of a Vector2D. 
	/// </summary>
	/// <param name="vec">The input Vector2D.</param>
	/// <param name="x">The output X element.</param>
	/// <param name="y">The output Y element.</param>
	public static void Deconstruct(this Vector2D vec, out double x, out double y) =>
		(x, y) = (vec.X, vec.Y);
	/// <summary>
	/// Deconstructs the elements of a Vector3. 
	/// </summary>
	/// <param name="vec">The input Vector3.</param>
	/// <param name="x">The output X element.</param>
	/// <param name="y">The output Y element.</param>
	/// <param name="z">The output Z element.</param>
	public static void Deconstruct(this Vector3 vec, out float x, out float y, out float z) =>
		(x, y, z) = (vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Deconstructs the elements of a Vector4. 
	/// </summary>
	/// <param name="vec">The input Vector4.</param>
	/// <param name="x">The output X element.</param>
	/// <param name="y">The output Y element.</param>
	/// <param name="z">The output Z element.</param>
	/// <param name="w">The output W element.</param>
	public static void Deconstruct(this Vector4 vec, out float x, out float y, out float z, out float w) =>
		(x, y, z, w) = (vec.X, vec.Y, vec.Z, vec.W);

	/// <summary>
	/// Converts a Vector2 to a tuple containing the same elements.
	/// </summary>
	/// <param name="vec">The input Vector2.</param>
	/// <returns>A tuple containing the elements of <paramref name="vec"/>.</returns>
	public static (float X, float Y) ToTuple(this Vector2 vec) =>
		(vec.X, vec.Y);
	/// <summary>
	/// Converts a Vector2D to a tuple containing the same elements.
	/// </summary>
	/// <param name="vec">The input Vector2D.</param>
	/// <returns>A tuple containing the elements of <paramref name="vec"/>.</returns>
	public static (double X, double Y) ToTuple(this Vector2D vec) =>
		(vec.X, vec.Y);
	/// <summary>
	/// Converts a Vector3 to a tuple containing the same elements.
	/// </summary>
	/// <param name="vec">The input Vector3.</param>
	/// <returns>A tuple containing the elements of <paramref name="vec"/>.</returns>
	public static (float X, float Y, float Z) ToTuple(this Vector3 vec) =>
		(vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Converts a Vector4 to a tuple containing the same elements.
	/// </summary>
	/// <param name="vec">The input Vector4.</param>
	/// <returns>A tuple containing the elements of <paramref name="vec"/>.</returns>
	public static (float X, float Y, float Z, float W) ToTuple(this Vector4 vec) =>
		(vec.X, vec.Y, vec.Z, vec.W);

	/// <summary>
	/// Converts a Vector2 to an array containing the same elements.
	/// </summary>
	/// <param name="vec">The input Vector2.</param>
	/// <returns>An array containing the elements of <paramref name="vec"/>.</returns>
	public static float[] ToArray(this Vector2 vec) => new[] { vec.X, vec.Y };
	/// <summary>
	/// Converts a Vector2D to an array containing the same elements.
	/// </summary>
	/// <param name="vec">The input Vector2D.</param>
	/// <returns>An array containing the elements of <paramref name="vec"/>.</returns>
	public static double[] ToArray(this Vector2D vec) => new[] { vec.X, vec.Y };
	/// <summary>
	/// Converts a Vector3 to an array containing the same elements.
	/// </summary>
	/// <param name="vec">The input Vector3.</param>
	/// <returns>An array containing the elements of <paramref name="vec"/>.</returns>
	public static float[] ToArray(this Vector3 vec) => new[] { vec.X, vec.Y, vec.Z };
	/// <summary>
	/// Converts a Vector4 to an array containing the same elements.
	/// </summary>
	/// <param name="vec">The input Vector4.</param>
	/// <returns>An array containing the elements of <paramref name="vec"/>.</returns>
	public static float[] ToArray(this Vector4 vec) => new[] { vec.X, vec.Y, vec.Z, vec.W };

	/// <summary>
	/// Creates a Vector2 from the elements of an input tuple.
	/// </summary>
	/// <param name="tuple">The tuple to convert.</param>
	/// <returns>A Vector2 with the elements from <paramref name="tuple"/>.</returns>
	public static Vector2 ToVector(this (float X, float Y) tuple) =>
		new(tuple.X, tuple.Y);
	/// <summary>
	/// Creates a Vector2D from the elements of an input tuple.
	/// </summary>
	/// <param name="tuple">The tuple to convert.</param>
	/// <returns>A Vector2Dwith the elements from <paramref name="tuple"/>.</returns>
	public static Vector2D ToVector(this (double X, double Y) tuple) =>
		new(tuple.X, tuple.Y);
	/// <summary>
	/// Creates a Vector3 from the elements of an input tuple.
	/// </summary>
	/// <param name="tuple">The tuple to convert.</param>
	/// <returns>A Vector3 with the elements from <paramref name="tuple"/>.</returns>
	public static Vector3 ToVector(this (float X, float Y, float Z) tuple) =>
		new(tuple.X, tuple.Y, tuple.Z);
	/// <summary>
	/// Creates a Vector4 from the elements of an input tuple.
	/// </summary>
	/// <param name="tuple">The tuple to convert.</param>
	/// <returns>A Vector4 with the elements from <paramref name="tuple"/>.</returns>
	public static Vector4 ToVector(this (float X, float Y, float Z, float W) tuple) =>
		new(tuple.X, tuple.Y, tuple.Z, tuple.W);

	/// <inheritdoc cref="ToVector(ValueTuple{float, float})" />
	public static Vector2 ToVector(this (int X, int Y) tuple) =>
		new(tuple.X, tuple.Y);
	/// <inheritdoc cref="ToVector(ValueTuple{float, float})" />
	public static Vector2D ToVector2D(this (int X, int Y) tuple) =>
		new(tuple.X, tuple.Y);
	/// <inheritdoc cref="ToVector(ValueTuple{float, float, float})" />
	public static Vector3 ToVector(this (int X, int Y, int Z) tuple) =>
		new(tuple.X, tuple.Y, tuple.Z);
	/// <inheritdoc cref="ToVector(ValueTuple{float, float, float, float})" />
	public static Vector4 ToVector(this (int X, int Y, int Z, int W) tuple) =>
		new(tuple.X, tuple.Y, tuple.Z, tuple.W);

	/// <summary>
	/// Maps each element of an input vector using a supplied function to produce a new vector.
	/// </summary>
	/// <param name="vec">The input vector.</param>
	/// <param name="functor">The function to apply to each element of <paramref name="vec"/>.</param>
	/// <returns>The mapped vector.</returns>
	public static Vector2 Map(this Vector2 vec, Func<float, float> functor) =>
		new(functor(vec.X), functor(vec.Y));
	/// <inheritdoc cref="Map(Vector2, Func{float, float})" />
	public static Vector2D Map(this Vector2 vec, Func<double, double> functor) =>
		new(functor(vec.X), functor(vec.Y));
	/// <inheritdoc cref="Map(Vector2, Func{float, float})" />
	public static Vector3 Map(this Vector3 vec, Func<float, float> functor) =>
		new(functor(vec.X), functor(vec.Y), functor(vec.Z));
	/// <inheritdoc cref="Map(Vector2, Func{float, float})" />
	public static Vector4 Map(this Vector4 vec, Func<float, float> functor) =>
		new(functor(vec.X), functor(vec.Y), functor(vec.Z), functor(vec.W));

	/// <summary>
	/// Normalizes an input vector without modifying the original.
	/// </summary>
	/// <param name="vec">The vector to normalize.</param>
	/// <returns>The normalized version of <paramref name="vec"/>.</returns>
	public static Vector2 Normalize(this Vector2 vec) => Vector2.Normalize(vec);
	/// <inheritdoc cref="Normalize(Vector2)" />
	public static Vector2D Normalize(this Vector2D vec) => Vector2D.Normalize(vec);
	/// <inheritdoc cref="Normalize(Vector2)" />
	public static Vector3 Normalize(this Vector3 vec) => Vector3.Normalize(vec);
	/// <inheritdoc cref="Normalize(Vector2)" />
	public static Vector4 Normalize(this Vector4 vec) => Vector4.Normalize(vec);

	/// <summary>
	/// Makes a new vector with the absolute value of each element of an input vector.
	/// </summary>
	/// <param name="vec">The input vector.</param>
	/// <returns>The absolute value of <paramref name="vec"/>.</returns>
	public static Vector2 Abs(this Vector2 vec) => Vector2.Abs(vec);
	/// <inheritdoc cref="Abs(Vector2)" />
	public static Vector2D Abs(this Vector2D vec) => Vector2D.Abs(vec);
	/// <inheritdoc cref="Abs(Vector2)" />
	public static Vector3 Abs(this Vector3 vec) => Vector3.Abs(vec);
	/// <inheritdoc cref="Abs(Vector2)" />
	public static Vector4 Abs(this Vector4 vec) => Vector4.Abs(vec);

	/// <summary>
	/// The 2d cross product of two Vector2 values.
	/// </summary>
	/// <param name="a">The first vector.</param>
	/// <param name="b">The second vector.</param>
	/// <returns>The 2d cross product of <paramref name="a"/> and <paramref name="b"/>.</returns>
	public static float Cross(this Vector2 a, Vector2 b) => a.X * b.Y - a.Y * b.X;
	/// <inheritdoc cref="Cross(Vector2,Vector2)" />
	public static double Cross(this Vector2D a, Vector2D b) => a.X * b.Y - a.Y * b.X;

	/// <summary>
	/// Gives the Euclidean distance of two vectors.
	/// </summary>
	/// <param name="a">The first vector.</param>
	/// <param name="b">The second vector.</param>
	/// <returns>The Euclidean distance between <paramref name="a"/> and <paramref name="b"/>.</returns>
	public static float DistanceTo(this Vector2 a, Vector2 b) => Vector2.Distance(a, b);
	/// <inheritdoc cref="DistanceTo(Vector2, Vector2)" />
	public static double DistanceTo(this Vector2D a, Vector2D b) => Vector2D.Distance(a, b);
	/// <inheritdoc cref="DistanceTo(Vector2, Vector2)" />
	public static float DistanceTo(this Vector3 a, Vector3 b) => Vector3.Distance(a, b);
	/// <inheritdoc cref="DistanceTo(Vector2, Vector2)" />
	public static float DistanceTo(this Vector4 a, Vector4 b) => Vector4.Distance(a, b);

	/// <summary>
	/// Gives the square of the Euclidean distance of two vectors.
	/// </summary>
	/// <param name="a">The first vector.</param>
	/// <param name="b">The second vector.</param>
	/// <returns>The square of the Euclidean distance between <paramref name="a"/> and <paramref name="b"/>.</returns>
	public static float SquaredDistanceTo(this Vector2 a, Vector2 b) => Vector2.DistanceSquared(a, b);
	/// <inheritdoc cref="SquaredDistanceTo(Vector2, Vector2)" />
	public static double SquaredDistanceTo(this Vector2D a, Vector2D b) => Vector2D.DistanceSquared(a, b);
	/// <inheritdoc cref="SquaredDistanceTo(Vector2, Vector2)" />
	public static float SquaredDistanceTo(this Vector3 a, Vector3 b) => Vector3.DistanceSquared(a, b);
	/// <inheritdoc cref="SquaredDistanceTo(Vector2, Vector2)" />
	public static float SquaredDistanceTo(this Vector4 a, Vector4 b) => Vector4.DistanceSquared(a, b);

	/// <summary>
	/// Takes the elementwise minimum of two vectors.
	/// </summary>
	/// <param name="a">The first vector.</param>
	/// <param name="b">The second vector.</param>
	/// <returns>The elementwise minimum of <paramref name="a"/> and <paramref name="b"/>.</returns>
	public static Vector2 Min(this Vector2 a, Vector2 b) => Vector2.Min(a, b);
	/// <inheritdoc cref="Min(Vector2, Vector2)" />
	public static Vector2D Min(this Vector2D a, Vector2D b) => Vector2D.Min(a, b);
	/// <inheritdoc cref="Min(Vector2, Vector2)" />
	public static Vector3 Min(this Vector3 a, Vector3 b) => Vector3.Min(a, b);
	/// <inheritdoc cref="Min(Vector2, Vector2)" />
	public static Vector4 Min(this Vector4 a, Vector4 b) => Vector4.Min(a, b);

	/// <summary>
	/// Takes the elementwise maximum of two vectors.
	/// </summary>
	/// <param name="a">The first vector.</param>
	/// <param name="b">The second vector.</param>
	/// <returns>The elementwise maximum of <paramref name="a"/> and <paramref name="b"/>.</returns>
	public static Vector2 Max(this Vector2 a, Vector2 b) => Vector2.Max(a, b);
	/// <inheritdoc cref="Max(Vector2, Vector2)" />
	public static Vector2D Max(this Vector2D a, Vector2D b) => Vector2D.Max(a, b);
	/// <inheritdoc cref="Max(Vector2, Vector2)" />
	public static Vector3 Max(this Vector3 a, Vector3 b) => Vector3.Max(a, b);
	/// <inheritdoc cref="Max(Vector2, Vector2)" />
	public static Vector4 Max(this Vector4 a, Vector4 b) => Vector4.Max(a, b);
	/// <summary>
	/// Performs linear interpolation.
	/// </summary>
	/// <param name="a">The start vector.</param>
	/// <param name="b">The end vector.</param>
	/// <param name="t">A value ranging from 0 to 1.</param>
	/// <returns>The linear interpolation of <paramref name="a"/> to <paramref name="b"/> using <paramref name="t"/> in the range 0-1.</returns>
	public static Vector2 Lerp(this Vector2 a, Vector2 b, float t) => (b - a) * t + a;
	/// <inheritdoc cref="Lerp(Vector2, Vector2, float)" />

	public static Vector2D Lerp(this Vector2D a, Vector2D b, double t) => (b - a) * t + a;
	/// <inheritdoc cref="Lerp(Vector2, Vector2, float)" />
	public static Vector3 Lerp(this Vector3 a, Vector3 b, float t) => (b - a) * t + a;
	/// <inheritdoc cref="Lerp(Vector2, Vector2, float)" />
	public static Vector4 Lerp(this Vector4 a, Vector4 b, float t) => (b - a) * t + a;

	/// <summary>
	/// Rotates a Vector2 by an arbitrary angle in radians.
	/// </summary>
	/// <param name="vec">The vector to rotate.</param>
	/// <param name="theta">The angle in radians.</param>
	/// <returns>The vector <paramref name="vec"/> rotated by <paramref name="theta"/> radians.</returns>
	public static Vector2 Rotate(this Vector2 vec, float theta) {
		var ca = MathF.Cos(theta);
		var sa = MathF.Sin(theta);
		return new(
			vec.X * ca - vec.Y * sa, 
			vec.X * sa + vec.Y * ca
		);
	}

	/// <summary>
	/// Rotates a Vector2D by an arbitrary angle in radians.
	/// </summary>
	/// <param name="vec">The vector to rotate.</param>
	/// <param name="theta">The angle in radians.</param>
	/// <returns>The vector <paramref name="vec"/> rotated by <paramref name="theta"/> radians.</returns>
	public static Vector2D Rotate(this Vector2D vec, double theta) {
		var ca = Math.Cos(theta);
		var sa = Math.Sin(theta);
		return new(
			vec.X * ca - vec.Y * sa, 
			vec.X * sa + vec.Y * ca
		);
	}

	/// <summary>
	/// Returns the centroid of a given sequence of vectors.
	/// </summary>
	/// <param name="source">The sequence of vectors.</param>
	/// <returns>The centroid of the vectors. If the sequence is empty, the origin is returned.</returns>
	public static Vector2 Centroid(this IEnumerable<Vector2> source) {
		var acc = Vector2.Zero;
		var count = 0;
		foreach(var point in source) {
			acc += point;
			count++;
		}
		if(count == 0) return Vector2.Zero;
		return acc / count;
	}
	/// <inheritdoc cref="Centroid(IEnumerable{Vector2})" />
	public static Vector2D Centroid(this IEnumerable<Vector2D> source) {
		var acc = Vector2D.Zero;
		var count = 0;
		foreach(var point in source) {
			acc += point;
			count++;
		}
		if(count == 0) return Vector2D.Zero;
		return acc / count;
	}
	/// <inheritdoc cref="Centroid(IEnumerable{Vector2})" />
	public static Vector3 Centroid(this IEnumerable<Vector3> source) {
		var acc = Vector3.Zero;
		var count = 0;
		foreach(var point in source) {
			acc += point;
			count++;
		}
		if(count == 0) return Vector3.Zero;
		return acc / count;
	}
	/// <inheritdoc cref="Centroid(IEnumerable{Vector2})" />
	public static Vector4 Centroid(this IEnumerable<Vector4> source) {
		var acc = Vector4.Zero;
		var count = 0;
		foreach(var point in source) {
			acc += point;
			count++;
		}
		if(count == 0) return Vector4.Zero;
		return acc / count;
	}
}