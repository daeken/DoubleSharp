using System.Numerics;

namespace DoubleSharp.MathPlus; 

public static class VectorExtensions {
	public static void Deconstruct(this Vector2 vec, out float x, out float y) =>
		(x, y) = (vec.X, vec.Y);
	public static void Deconstruct(this Vector3 vec, out float x, out float y, out float z) =>
		(x, y, z) = (vec.X, vec.Y, vec.Z);
	public static void Deconstruct(this Vector4 vec, out float x, out float y, out float z, out float w) =>
		(x, y, z, w) = (vec.X, vec.Y, vec.Z, vec.W);

	public static (float X, float Y) ToTuple(this Vector2 vec) =>
		(vec.X, vec.Y);
	public static (float X, float Y, float Z) ToTuple(this Vector3 vec) =>
		(vec.X, vec.Y, vec.Z);
	public static (float X, float Y, float Z, float W) ToTuple(this Vector4 vec) =>
		(vec.X, vec.Y, vec.Z, vec.W);

	public static float[] ToArray(this Vector2 vec) => new[] { vec.X, vec.Y };
	public static float[] ToArray(this Vector3 vec) => new[] { vec.X, vec.Y, vec.Z };
	public static float[] ToArray(this Vector4 vec) => new[] { vec.X, vec.Y, vec.Z, vec.W };

	public static Vector2 ToVector(this (float X, float Y) tuple) =>
		new(tuple.X, tuple.Y);
	public static Vector3 ToVector(this (float X, float Y, float Z) tuple) =>
		new(tuple.X, tuple.Y, tuple.Z);
	public static Vector4 ToVector(this (float X, float Y, float Z, float W) tuple) =>
		new(tuple.X, tuple.Y, tuple.Z, tuple.W);

	public static Vector2 ToVector(this (int X, int Y) tuple) =>
		new(tuple.X, tuple.Y);
	public static Vector3 ToVector(this (int X, int Y, int Z) tuple) =>
		new(tuple.X, tuple.Y, tuple.Z);
	public static Vector4 ToVector(this (int X, int Y, int Z, int W) tuple) =>
		new(tuple.X, tuple.Y, tuple.Z, tuple.W);

	public static Vector2 Map(this Vector2 vec, Func<float, float> functor) =>
		new(functor(vec.X), functor(vec.Y));
	public static Vector3 Map(this Vector3 vec, Func<float, float> functor) =>
		new(functor(vec.X), functor(vec.Y), functor(vec.Z));
	public static Vector4 Map(this Vector4 vec, Func<float, float> functor) =>
		new(functor(vec.X), functor(vec.Y), functor(vec.Z), functor(vec.W));

	public static Vector2 Normalize(this Vector2 vec) => Vector2.Normalize(vec);
	public static Vector3 Normalize(this Vector3 vec) => Vector3.Normalize(vec);
	public static Vector4 Normalize(this Vector4 vec) => Vector4.Normalize(vec);

	public static Vector2 Abs(this Vector2 vec) => Vector2.Abs(vec);
	public static Vector3 Abs(this Vector3 vec) => Vector3.Abs(vec);
	public static Vector4 Abs(this Vector4 vec) => Vector4.Abs(vec);

	public static float Cross(this Vector2 a, Vector2 b) => a.X * b.Y - a.Y * b.X;

	public static float DistanceTo(this Vector2 a, Vector2 b) => Vector2.Distance(a, b);
	public static float DistanceTo(this Vector3 a, Vector3 b) => Vector3.Distance(a, b);
	public static float DistanceTo(this Vector4 a, Vector4 b) => Vector4.Distance(a, b);

	public static float SquaredDistanceTo(this Vector2 a, Vector2 b) => Vector2.DistanceSquared(a, b);
	public static float SquaredDistanceTo(this Vector3 a, Vector3 b) => Vector3.DistanceSquared(a, b);
	public static float SquaredDistanceTo(this Vector4 a, Vector4 b) => Vector4.DistanceSquared(a, b);

	public static Vector2 Min(this Vector2 a, Vector2 b) => Vector2.Min(a, b);
	public static Vector3 Min(this Vector3 a, Vector3 b) => Vector3.Min(a, b);
	public static Vector4 Min(this Vector4 a, Vector4 b) => Vector4.Min(a, b);

	public static Vector2 Max(this Vector2 a, Vector2 b) => Vector2.Max(a, b);
	public static Vector3 Max(this Vector3 a, Vector3 b) => Vector3.Max(a, b);
	public static Vector4 Max(this Vector4 a, Vector4 b) => Vector4.Max(a, b);

	public static Vector2 Rotate(this Vector2 vec, float theta) {
		var ca = MathF.Cos(theta);
		var sa = MathF.Sin(theta);
		return new(
			vec.X * ca - vec.Y * sa, 
			vec.X * sa + vec.Y * ca
		);
	}

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