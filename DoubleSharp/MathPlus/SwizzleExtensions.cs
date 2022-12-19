using System.Numerics;

// ReSharper disable InconsistentNaming

namespace DoubleSharp.MathPlus; 

public static class SwizzleExtensions {
#region 2x2 Swizzles
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 XX(this Vector2 vec) => new(vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 XY(this Vector2 vec) => vec;
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 YX(this Vector2 vec) => new(vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 YY(this Vector2 vec) => new(vec.Y, vec.Y);
#endregion

#region 3x2 Swizzles
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 XX(this Vector3 vec) => new(vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 XY(this Vector3 vec) => new(vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 XZ(this Vector3 vec) => new(vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 YX(this Vector3 vec) => new(vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 YY(this Vector3 vec) => new(vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 YZ(this Vector3 vec) => new(vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 ZX(this Vector3 vec) => new(vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 ZY(this Vector3 vec) => new(vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 ZZ(this Vector3 vec) => new(vec.Z, vec.Z);
#endregion

#region 4x2 Swizzles
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 XX(this Vector4 vec) => new(vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 XY(this Vector4 vec) => new(vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 XZ(this Vector4 vec) => new(vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 XW(this Vector4 vec) => new(vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 YX(this Vector4 vec) => new(vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 YY(this Vector4 vec) => new(vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 YZ(this Vector4 vec) => new(vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 YW(this Vector4 vec) => new(vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 ZX(this Vector4 vec) => new(vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 ZY(this Vector4 vec) => new(vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 ZZ(this Vector4 vec) => new(vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 ZW(this Vector4 vec) => new(vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 WX(this Vector4 vec) => new(vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 WY(this Vector4 vec) => new(vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 WZ(this Vector4 vec) => new(vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector2 with elements from <paramref name="vec"/>: W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector2 WW(this Vector4 vec) => new(vec.W, vec.W);
#endregion

#region 2x3 Swizzles
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XXX(this Vector2 vec) => new(vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XXY(this Vector2 vec) => new(vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XYX(this Vector2 vec) => new(vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XYY(this Vector2 vec) => new(vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YXX(this Vector2 vec) => new(vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YXY(this Vector2 vec) => new(vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YYX(this Vector2 vec) => new(vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YYY(this Vector2 vec) => new(vec.Y, vec.Y, vec.Y);
#endregion

#region 3x3 Swizzles
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XXX(this Vector3 vec) => new(vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XXY(this Vector3 vec) => new(vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XXZ(this Vector3 vec) => new(vec.X, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XYX(this Vector3 vec) => new(vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XYY(this Vector3 vec) => new(vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XYZ(this Vector3 vec) => vec;
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XZX(this Vector3 vec) => new(vec.X, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XZY(this Vector3 vec) => new(vec.X, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XZZ(this Vector3 vec) => new(vec.X, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YXX(this Vector3 vec) => new(vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YXY(this Vector3 vec) => new(vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YXZ(this Vector3 vec) => new(vec.Y, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YYX(this Vector3 vec) => new(vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YYY(this Vector3 vec) => new(vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YYZ(this Vector3 vec) => new(vec.Y, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YZX(this Vector3 vec) => new(vec.Y, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YZY(this Vector3 vec) => new(vec.Y, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YZZ(this Vector3 vec) => new(vec.Y, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZXX(this Vector3 vec) => new(vec.Z, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZXY(this Vector3 vec) => new(vec.Z, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZXZ(this Vector3 vec) => new(vec.Z, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZYX(this Vector3 vec) => new(vec.Z, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZYY(this Vector3 vec) => new(vec.Z, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZYZ(this Vector3 vec) => new(vec.Z, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZZX(this Vector3 vec) => new(vec.Z, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZZY(this Vector3 vec) => new(vec.Z, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZZZ(this Vector3 vec) => new(vec.Z, vec.Z, vec.Z);
#endregion

#region 4x3 Swizzles
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XXX(this Vector4 vec) => new(vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XXY(this Vector4 vec) => new(vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XXZ(this Vector4 vec) => new(vec.X, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XXW(this Vector4 vec) => new(vec.X, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XYX(this Vector4 vec) => new(vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XYY(this Vector4 vec) => new(vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XYZ(this Vector4 vec) => new(vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XYW(this Vector4 vec) => new(vec.X, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XZX(this Vector4 vec) => new(vec.X, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XZY(this Vector4 vec) => new(vec.X, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XZZ(this Vector4 vec) => new(vec.X, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XZW(this Vector4 vec) => new(vec.X, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XWX(this Vector4 vec) => new(vec.X, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XWY(this Vector4 vec) => new(vec.X, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XWZ(this Vector4 vec) => new(vec.X, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: X, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 XWW(this Vector4 vec) => new(vec.X, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YXX(this Vector4 vec) => new(vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YXY(this Vector4 vec) => new(vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YXZ(this Vector4 vec) => new(vec.Y, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YXW(this Vector4 vec) => new(vec.Y, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YYX(this Vector4 vec) => new(vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YYY(this Vector4 vec) => new(vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YYZ(this Vector4 vec) => new(vec.Y, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YYW(this Vector4 vec) => new(vec.Y, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YZX(this Vector4 vec) => new(vec.Y, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YZY(this Vector4 vec) => new(vec.Y, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YZZ(this Vector4 vec) => new(vec.Y, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YZW(this Vector4 vec) => new(vec.Y, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YWX(this Vector4 vec) => new(vec.Y, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YWY(this Vector4 vec) => new(vec.Y, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YWZ(this Vector4 vec) => new(vec.Y, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Y, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 YWW(this Vector4 vec) => new(vec.Y, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZXX(this Vector4 vec) => new(vec.Z, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZXY(this Vector4 vec) => new(vec.Z, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZXZ(this Vector4 vec) => new(vec.Z, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZXW(this Vector4 vec) => new(vec.Z, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZYX(this Vector4 vec) => new(vec.Z, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZYY(this Vector4 vec) => new(vec.Z, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZYZ(this Vector4 vec) => new(vec.Z, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZYW(this Vector4 vec) => new(vec.Z, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZZX(this Vector4 vec) => new(vec.Z, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZZY(this Vector4 vec) => new(vec.Z, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZZZ(this Vector4 vec) => new(vec.Z, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZZW(this Vector4 vec) => new(vec.Z, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZWX(this Vector4 vec) => new(vec.Z, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZWY(this Vector4 vec) => new(vec.Z, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZWZ(this Vector4 vec) => new(vec.Z, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: Z, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 ZWW(this Vector4 vec) => new(vec.Z, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WXX(this Vector4 vec) => new(vec.W, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WXY(this Vector4 vec) => new(vec.W, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WXZ(this Vector4 vec) => new(vec.W, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WXW(this Vector4 vec) => new(vec.W, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WYX(this Vector4 vec) => new(vec.W, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WYY(this Vector4 vec) => new(vec.W, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WYZ(this Vector4 vec) => new(vec.W, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WYW(this Vector4 vec) => new(vec.W, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WZX(this Vector4 vec) => new(vec.W, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WZY(this Vector4 vec) => new(vec.W, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WZZ(this Vector4 vec) => new(vec.W, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WZW(this Vector4 vec) => new(vec.W, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WWX(this Vector4 vec) => new(vec.W, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WWY(this Vector4 vec) => new(vec.W, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WWZ(this Vector4 vec) => new(vec.W, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector3 with elements from <paramref name="vec"/>: W, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector3 WWW(this Vector4 vec) => new(vec.W, vec.W, vec.W);
#endregion

#region 2x4 Swizzles
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXXX(this Vector2 vec) => new(vec.X, vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXXY(this Vector2 vec) => new(vec.X, vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXYX(this Vector2 vec) => new(vec.X, vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXYY(this Vector2 vec) => new(vec.X, vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYXX(this Vector2 vec) => new(vec.X, vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYXY(this Vector2 vec) => new(vec.X, vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYYX(this Vector2 vec) => new(vec.X, vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYYY(this Vector2 vec) => new(vec.X, vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXXX(this Vector2 vec) => new(vec.Y, vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXXY(this Vector2 vec) => new(vec.Y, vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXYX(this Vector2 vec) => new(vec.Y, vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXYY(this Vector2 vec) => new(vec.Y, vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYXX(this Vector2 vec) => new(vec.Y, vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYXY(this Vector2 vec) => new(vec.Y, vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYYX(this Vector2 vec) => new(vec.Y, vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYYY(this Vector2 vec) => new(vec.Y, vec.Y, vec.Y, vec.Y);
#endregion

#region 3x4 Swizzles
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXXX(this Vector3 vec) => new(vec.X, vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXXY(this Vector3 vec) => new(vec.X, vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXXZ(this Vector3 vec) => new(vec.X, vec.X, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXYX(this Vector3 vec) => new(vec.X, vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXYY(this Vector3 vec) => new(vec.X, vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXYZ(this Vector3 vec) => new(vec.X, vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXZX(this Vector3 vec) => new(vec.X, vec.X, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXZY(this Vector3 vec) => new(vec.X, vec.X, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXZZ(this Vector3 vec) => new(vec.X, vec.X, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYXX(this Vector3 vec) => new(vec.X, vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYXY(this Vector3 vec) => new(vec.X, vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYXZ(this Vector3 vec) => new(vec.X, vec.Y, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYYX(this Vector3 vec) => new(vec.X, vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYYY(this Vector3 vec) => new(vec.X, vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYYZ(this Vector3 vec) => new(vec.X, vec.Y, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYZX(this Vector3 vec) => new(vec.X, vec.Y, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYZY(this Vector3 vec) => new(vec.X, vec.Y, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYZZ(this Vector3 vec) => new(vec.X, vec.Y, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZXX(this Vector3 vec) => new(vec.X, vec.Z, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZXY(this Vector3 vec) => new(vec.X, vec.Z, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZXZ(this Vector3 vec) => new(vec.X, vec.Z, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZYX(this Vector3 vec) => new(vec.X, vec.Z, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZYY(this Vector3 vec) => new(vec.X, vec.Z, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZYZ(this Vector3 vec) => new(vec.X, vec.Z, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZZX(this Vector3 vec) => new(vec.X, vec.Z, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZZY(this Vector3 vec) => new(vec.X, vec.Z, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZZZ(this Vector3 vec) => new(vec.X, vec.Z, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXXX(this Vector3 vec) => new(vec.Y, vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXXY(this Vector3 vec) => new(vec.Y, vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXXZ(this Vector3 vec) => new(vec.Y, vec.X, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXYX(this Vector3 vec) => new(vec.Y, vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXYY(this Vector3 vec) => new(vec.Y, vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXYZ(this Vector3 vec) => new(vec.Y, vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXZX(this Vector3 vec) => new(vec.Y, vec.X, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXZY(this Vector3 vec) => new(vec.Y, vec.X, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXZZ(this Vector3 vec) => new(vec.Y, vec.X, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYXX(this Vector3 vec) => new(vec.Y, vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYXY(this Vector3 vec) => new(vec.Y, vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYXZ(this Vector3 vec) => new(vec.Y, vec.Y, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYYX(this Vector3 vec) => new(vec.Y, vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYYY(this Vector3 vec) => new(vec.Y, vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYYZ(this Vector3 vec) => new(vec.Y, vec.Y, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYZX(this Vector3 vec) => new(vec.Y, vec.Y, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYZY(this Vector3 vec) => new(vec.Y, vec.Y, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYZZ(this Vector3 vec) => new(vec.Y, vec.Y, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZXX(this Vector3 vec) => new(vec.Y, vec.Z, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZXY(this Vector3 vec) => new(vec.Y, vec.Z, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZXZ(this Vector3 vec) => new(vec.Y, vec.Z, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZYX(this Vector3 vec) => new(vec.Y, vec.Z, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZYY(this Vector3 vec) => new(vec.Y, vec.Z, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZYZ(this Vector3 vec) => new(vec.Y, vec.Z, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZZX(this Vector3 vec) => new(vec.Y, vec.Z, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZZY(this Vector3 vec) => new(vec.Y, vec.Z, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZZZ(this Vector3 vec) => new(vec.Y, vec.Z, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXXX(this Vector3 vec) => new(vec.Z, vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXXY(this Vector3 vec) => new(vec.Z, vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXXZ(this Vector3 vec) => new(vec.Z, vec.X, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXYX(this Vector3 vec) => new(vec.Z, vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXYY(this Vector3 vec) => new(vec.Z, vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXYZ(this Vector3 vec) => new(vec.Z, vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXZX(this Vector3 vec) => new(vec.Z, vec.X, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXZY(this Vector3 vec) => new(vec.Z, vec.X, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXZZ(this Vector3 vec) => new(vec.Z, vec.X, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYXX(this Vector3 vec) => new(vec.Z, vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYXY(this Vector3 vec) => new(vec.Z, vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYXZ(this Vector3 vec) => new(vec.Z, vec.Y, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYYX(this Vector3 vec) => new(vec.Z, vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYYY(this Vector3 vec) => new(vec.Z, vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYYZ(this Vector3 vec) => new(vec.Z, vec.Y, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYZX(this Vector3 vec) => new(vec.Z, vec.Y, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYZY(this Vector3 vec) => new(vec.Z, vec.Y, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYZZ(this Vector3 vec) => new(vec.Z, vec.Y, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZXX(this Vector3 vec) => new(vec.Z, vec.Z, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZXY(this Vector3 vec) => new(vec.Z, vec.Z, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZXZ(this Vector3 vec) => new(vec.Z, vec.Z, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZYX(this Vector3 vec) => new(vec.Z, vec.Z, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZYY(this Vector3 vec) => new(vec.Z, vec.Z, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZYZ(this Vector3 vec) => new(vec.Z, vec.Z, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZZX(this Vector3 vec) => new(vec.Z, vec.Z, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZZY(this Vector3 vec) => new(vec.Z, vec.Z, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZZZ(this Vector3 vec) => new(vec.Z, vec.Z, vec.Z, vec.Z);
#endregion

#region 4x4 Swizzles
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXXX(this Vector4 vec) => new(vec.X, vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXXY(this Vector4 vec) => new(vec.X, vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXXZ(this Vector4 vec) => new(vec.X, vec.X, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXXW(this Vector4 vec) => new(vec.X, vec.X, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXYX(this Vector4 vec) => new(vec.X, vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXYY(this Vector4 vec) => new(vec.X, vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXYZ(this Vector4 vec) => new(vec.X, vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXYW(this Vector4 vec) => new(vec.X, vec.X, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXZX(this Vector4 vec) => new(vec.X, vec.X, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXZY(this Vector4 vec) => new(vec.X, vec.X, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXZZ(this Vector4 vec) => new(vec.X, vec.X, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXZW(this Vector4 vec) => new(vec.X, vec.X, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXWX(this Vector4 vec) => new(vec.X, vec.X, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXWY(this Vector4 vec) => new(vec.X, vec.X, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXWZ(this Vector4 vec) => new(vec.X, vec.X, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, X, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XXWW(this Vector4 vec) => new(vec.X, vec.X, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYXX(this Vector4 vec) => new(vec.X, vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYXY(this Vector4 vec) => new(vec.X, vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYXZ(this Vector4 vec) => new(vec.X, vec.Y, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYXW(this Vector4 vec) => new(vec.X, vec.Y, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYYX(this Vector4 vec) => new(vec.X, vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYYY(this Vector4 vec) => new(vec.X, vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYYZ(this Vector4 vec) => new(vec.X, vec.Y, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYYW(this Vector4 vec) => new(vec.X, vec.Y, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYZX(this Vector4 vec) => new(vec.X, vec.Y, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYZY(this Vector4 vec) => new(vec.X, vec.Y, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYZZ(this Vector4 vec) => new(vec.X, vec.Y, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYZW(this Vector4 vec) => vec;
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYWX(this Vector4 vec) => new(vec.X, vec.Y, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYWY(this Vector4 vec) => new(vec.X, vec.Y, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYWZ(this Vector4 vec) => new(vec.X, vec.Y, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Y, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XYWW(this Vector4 vec) => new(vec.X, vec.Y, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZXX(this Vector4 vec) => new(vec.X, vec.Z, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZXY(this Vector4 vec) => new(vec.X, vec.Z, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZXZ(this Vector4 vec) => new(vec.X, vec.Z, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZXW(this Vector4 vec) => new(vec.X, vec.Z, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZYX(this Vector4 vec) => new(vec.X, vec.Z, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZYY(this Vector4 vec) => new(vec.X, vec.Z, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZYZ(this Vector4 vec) => new(vec.X, vec.Z, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZYW(this Vector4 vec) => new(vec.X, vec.Z, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZZX(this Vector4 vec) => new(vec.X, vec.Z, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZZY(this Vector4 vec) => new(vec.X, vec.Z, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZZZ(this Vector4 vec) => new(vec.X, vec.Z, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZZW(this Vector4 vec) => new(vec.X, vec.Z, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZWX(this Vector4 vec) => new(vec.X, vec.Z, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZWY(this Vector4 vec) => new(vec.X, vec.Z, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZWZ(this Vector4 vec) => new(vec.X, vec.Z, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, Z, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XZWW(this Vector4 vec) => new(vec.X, vec.Z, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWXX(this Vector4 vec) => new(vec.X, vec.W, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWXY(this Vector4 vec) => new(vec.X, vec.W, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWXZ(this Vector4 vec) => new(vec.X, vec.W, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWXW(this Vector4 vec) => new(vec.X, vec.W, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWYX(this Vector4 vec) => new(vec.X, vec.W, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWYY(this Vector4 vec) => new(vec.X, vec.W, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWYZ(this Vector4 vec) => new(vec.X, vec.W, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWYW(this Vector4 vec) => new(vec.X, vec.W, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWZX(this Vector4 vec) => new(vec.X, vec.W, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWZY(this Vector4 vec) => new(vec.X, vec.W, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWZZ(this Vector4 vec) => new(vec.X, vec.W, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWZW(this Vector4 vec) => new(vec.X, vec.W, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWWX(this Vector4 vec) => new(vec.X, vec.W, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWWY(this Vector4 vec) => new(vec.X, vec.W, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWWZ(this Vector4 vec) => new(vec.X, vec.W, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: X, W, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 XWWW(this Vector4 vec) => new(vec.X, vec.W, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXXX(this Vector4 vec) => new(vec.Y, vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXXY(this Vector4 vec) => new(vec.Y, vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXXZ(this Vector4 vec) => new(vec.Y, vec.X, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXXW(this Vector4 vec) => new(vec.Y, vec.X, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXYX(this Vector4 vec) => new(vec.Y, vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXYY(this Vector4 vec) => new(vec.Y, vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXYZ(this Vector4 vec) => new(vec.Y, vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXYW(this Vector4 vec) => new(vec.Y, vec.X, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXZX(this Vector4 vec) => new(vec.Y, vec.X, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXZY(this Vector4 vec) => new(vec.Y, vec.X, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXZZ(this Vector4 vec) => new(vec.Y, vec.X, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXZW(this Vector4 vec) => new(vec.Y, vec.X, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXWX(this Vector4 vec) => new(vec.Y, vec.X, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXWY(this Vector4 vec) => new(vec.Y, vec.X, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXWZ(this Vector4 vec) => new(vec.Y, vec.X, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, X, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YXWW(this Vector4 vec) => new(vec.Y, vec.X, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYXX(this Vector4 vec) => new(vec.Y, vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYXY(this Vector4 vec) => new(vec.Y, vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYXZ(this Vector4 vec) => new(vec.Y, vec.Y, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYXW(this Vector4 vec) => new(vec.Y, vec.Y, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYYX(this Vector4 vec) => new(vec.Y, vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYYY(this Vector4 vec) => new(vec.Y, vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYYZ(this Vector4 vec) => new(vec.Y, vec.Y, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYYW(this Vector4 vec) => new(vec.Y, vec.Y, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYZX(this Vector4 vec) => new(vec.Y, vec.Y, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYZY(this Vector4 vec) => new(vec.Y, vec.Y, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYZZ(this Vector4 vec) => new(vec.Y, vec.Y, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYZW(this Vector4 vec) => new(vec.Y, vec.Y, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYWX(this Vector4 vec) => new(vec.Y, vec.Y, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYWY(this Vector4 vec) => new(vec.Y, vec.Y, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYWZ(this Vector4 vec) => new(vec.Y, vec.Y, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Y, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YYWW(this Vector4 vec) => new(vec.Y, vec.Y, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZXX(this Vector4 vec) => new(vec.Y, vec.Z, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZXY(this Vector4 vec) => new(vec.Y, vec.Z, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZXZ(this Vector4 vec) => new(vec.Y, vec.Z, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZXW(this Vector4 vec) => new(vec.Y, vec.Z, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZYX(this Vector4 vec) => new(vec.Y, vec.Z, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZYY(this Vector4 vec) => new(vec.Y, vec.Z, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZYZ(this Vector4 vec) => new(vec.Y, vec.Z, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZYW(this Vector4 vec) => new(vec.Y, vec.Z, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZZX(this Vector4 vec) => new(vec.Y, vec.Z, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZZY(this Vector4 vec) => new(vec.Y, vec.Z, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZZZ(this Vector4 vec) => new(vec.Y, vec.Z, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZZW(this Vector4 vec) => new(vec.Y, vec.Z, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZWX(this Vector4 vec) => new(vec.Y, vec.Z, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZWY(this Vector4 vec) => new(vec.Y, vec.Z, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZWZ(this Vector4 vec) => new(vec.Y, vec.Z, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, Z, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YZWW(this Vector4 vec) => new(vec.Y, vec.Z, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWXX(this Vector4 vec) => new(vec.Y, vec.W, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWXY(this Vector4 vec) => new(vec.Y, vec.W, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWXZ(this Vector4 vec) => new(vec.Y, vec.W, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWXW(this Vector4 vec) => new(vec.Y, vec.W, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWYX(this Vector4 vec) => new(vec.Y, vec.W, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWYY(this Vector4 vec) => new(vec.Y, vec.W, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWYZ(this Vector4 vec) => new(vec.Y, vec.W, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWYW(this Vector4 vec) => new(vec.Y, vec.W, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWZX(this Vector4 vec) => new(vec.Y, vec.W, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWZY(this Vector4 vec) => new(vec.Y, vec.W, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWZZ(this Vector4 vec) => new(vec.Y, vec.W, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWZW(this Vector4 vec) => new(vec.Y, vec.W, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWWX(this Vector4 vec) => new(vec.Y, vec.W, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWWY(this Vector4 vec) => new(vec.Y, vec.W, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWWZ(this Vector4 vec) => new(vec.Y, vec.W, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Y, W, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 YWWW(this Vector4 vec) => new(vec.Y, vec.W, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXXX(this Vector4 vec) => new(vec.Z, vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXXY(this Vector4 vec) => new(vec.Z, vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXXZ(this Vector4 vec) => new(vec.Z, vec.X, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXXW(this Vector4 vec) => new(vec.Z, vec.X, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXYX(this Vector4 vec) => new(vec.Z, vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXYY(this Vector4 vec) => new(vec.Z, vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXYZ(this Vector4 vec) => new(vec.Z, vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXYW(this Vector4 vec) => new(vec.Z, vec.X, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXZX(this Vector4 vec) => new(vec.Z, vec.X, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXZY(this Vector4 vec) => new(vec.Z, vec.X, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXZZ(this Vector4 vec) => new(vec.Z, vec.X, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXZW(this Vector4 vec) => new(vec.Z, vec.X, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXWX(this Vector4 vec) => new(vec.Z, vec.X, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXWY(this Vector4 vec) => new(vec.Z, vec.X, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXWZ(this Vector4 vec) => new(vec.Z, vec.X, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, X, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZXWW(this Vector4 vec) => new(vec.Z, vec.X, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYXX(this Vector4 vec) => new(vec.Z, vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYXY(this Vector4 vec) => new(vec.Z, vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYXZ(this Vector4 vec) => new(vec.Z, vec.Y, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYXW(this Vector4 vec) => new(vec.Z, vec.Y, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYYX(this Vector4 vec) => new(vec.Z, vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYYY(this Vector4 vec) => new(vec.Z, vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYYZ(this Vector4 vec) => new(vec.Z, vec.Y, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYYW(this Vector4 vec) => new(vec.Z, vec.Y, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYZX(this Vector4 vec) => new(vec.Z, vec.Y, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYZY(this Vector4 vec) => new(vec.Z, vec.Y, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYZZ(this Vector4 vec) => new(vec.Z, vec.Y, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYZW(this Vector4 vec) => new(vec.Z, vec.Y, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYWX(this Vector4 vec) => new(vec.Z, vec.Y, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYWY(this Vector4 vec) => new(vec.Z, vec.Y, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYWZ(this Vector4 vec) => new(vec.Z, vec.Y, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Y, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZYWW(this Vector4 vec) => new(vec.Z, vec.Y, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZXX(this Vector4 vec) => new(vec.Z, vec.Z, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZXY(this Vector4 vec) => new(vec.Z, vec.Z, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZXZ(this Vector4 vec) => new(vec.Z, vec.Z, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZXW(this Vector4 vec) => new(vec.Z, vec.Z, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZYX(this Vector4 vec) => new(vec.Z, vec.Z, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZYY(this Vector4 vec) => new(vec.Z, vec.Z, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZYZ(this Vector4 vec) => new(vec.Z, vec.Z, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZYW(this Vector4 vec) => new(vec.Z, vec.Z, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZZX(this Vector4 vec) => new(vec.Z, vec.Z, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZZY(this Vector4 vec) => new(vec.Z, vec.Z, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZZZ(this Vector4 vec) => new(vec.Z, vec.Z, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZZW(this Vector4 vec) => new(vec.Z, vec.Z, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZWX(this Vector4 vec) => new(vec.Z, vec.Z, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZWY(this Vector4 vec) => new(vec.Z, vec.Z, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZWZ(this Vector4 vec) => new(vec.Z, vec.Z, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, Z, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZZWW(this Vector4 vec) => new(vec.Z, vec.Z, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWXX(this Vector4 vec) => new(vec.Z, vec.W, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWXY(this Vector4 vec) => new(vec.Z, vec.W, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWXZ(this Vector4 vec) => new(vec.Z, vec.W, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWXW(this Vector4 vec) => new(vec.Z, vec.W, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWYX(this Vector4 vec) => new(vec.Z, vec.W, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWYY(this Vector4 vec) => new(vec.Z, vec.W, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWYZ(this Vector4 vec) => new(vec.Z, vec.W, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWYW(this Vector4 vec) => new(vec.Z, vec.W, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWZX(this Vector4 vec) => new(vec.Z, vec.W, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWZY(this Vector4 vec) => new(vec.Z, vec.W, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWZZ(this Vector4 vec) => new(vec.Z, vec.W, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWZW(this Vector4 vec) => new(vec.Z, vec.W, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWWX(this Vector4 vec) => new(vec.Z, vec.W, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWWY(this Vector4 vec) => new(vec.Z, vec.W, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWWZ(this Vector4 vec) => new(vec.Z, vec.W, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: Z, W, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 ZWWW(this Vector4 vec) => new(vec.Z, vec.W, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXXX(this Vector4 vec) => new(vec.W, vec.X, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXXY(this Vector4 vec) => new(vec.W, vec.X, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXXZ(this Vector4 vec) => new(vec.W, vec.X, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXXW(this Vector4 vec) => new(vec.W, vec.X, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXYX(this Vector4 vec) => new(vec.W, vec.X, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXYY(this Vector4 vec) => new(vec.W, vec.X, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXYZ(this Vector4 vec) => new(vec.W, vec.X, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXYW(this Vector4 vec) => new(vec.W, vec.X, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXZX(this Vector4 vec) => new(vec.W, vec.X, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXZY(this Vector4 vec) => new(vec.W, vec.X, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXZZ(this Vector4 vec) => new(vec.W, vec.X, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXZW(this Vector4 vec) => new(vec.W, vec.X, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXWX(this Vector4 vec) => new(vec.W, vec.X, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXWY(this Vector4 vec) => new(vec.W, vec.X, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXWZ(this Vector4 vec) => new(vec.W, vec.X, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, X, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WXWW(this Vector4 vec) => new(vec.W, vec.X, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYXX(this Vector4 vec) => new(vec.W, vec.Y, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYXY(this Vector4 vec) => new(vec.W, vec.Y, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYXZ(this Vector4 vec) => new(vec.W, vec.Y, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYXW(this Vector4 vec) => new(vec.W, vec.Y, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYYX(this Vector4 vec) => new(vec.W, vec.Y, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYYY(this Vector4 vec) => new(vec.W, vec.Y, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYYZ(this Vector4 vec) => new(vec.W, vec.Y, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYYW(this Vector4 vec) => new(vec.W, vec.Y, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYZX(this Vector4 vec) => new(vec.W, vec.Y, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYZY(this Vector4 vec) => new(vec.W, vec.Y, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYZZ(this Vector4 vec) => new(vec.W, vec.Y, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYZW(this Vector4 vec) => new(vec.W, vec.Y, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYWX(this Vector4 vec) => new(vec.W, vec.Y, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYWY(this Vector4 vec) => new(vec.W, vec.Y, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYWZ(this Vector4 vec) => new(vec.W, vec.Y, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Y, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WYWW(this Vector4 vec) => new(vec.W, vec.Y, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZXX(this Vector4 vec) => new(vec.W, vec.Z, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZXY(this Vector4 vec) => new(vec.W, vec.Z, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZXZ(this Vector4 vec) => new(vec.W, vec.Z, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZXW(this Vector4 vec) => new(vec.W, vec.Z, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZYX(this Vector4 vec) => new(vec.W, vec.Z, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZYY(this Vector4 vec) => new(vec.W, vec.Z, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZYZ(this Vector4 vec) => new(vec.W, vec.Z, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZYW(this Vector4 vec) => new(vec.W, vec.Z, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZZX(this Vector4 vec) => new(vec.W, vec.Z, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZZY(this Vector4 vec) => new(vec.W, vec.Z, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZZZ(this Vector4 vec) => new(vec.W, vec.Z, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZZW(this Vector4 vec) => new(vec.W, vec.Z, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZWX(this Vector4 vec) => new(vec.W, vec.Z, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZWY(this Vector4 vec) => new(vec.W, vec.Z, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZWZ(this Vector4 vec) => new(vec.W, vec.Z, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, Z, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WZWW(this Vector4 vec) => new(vec.W, vec.Z, vec.W, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, X, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWXX(this Vector4 vec) => new(vec.W, vec.W, vec.X, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, X, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWXY(this Vector4 vec) => new(vec.W, vec.W, vec.X, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, X, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWXZ(this Vector4 vec) => new(vec.W, vec.W, vec.X, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, X, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWXW(this Vector4 vec) => new(vec.W, vec.W, vec.X, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, Y, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWYX(this Vector4 vec) => new(vec.W, vec.W, vec.Y, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, Y, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWYY(this Vector4 vec) => new(vec.W, vec.W, vec.Y, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, Y, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWYZ(this Vector4 vec) => new(vec.W, vec.W, vec.Y, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, Y, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWYW(this Vector4 vec) => new(vec.W, vec.W, vec.Y, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, Z, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWZX(this Vector4 vec) => new(vec.W, vec.W, vec.Z, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, Z, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWZY(this Vector4 vec) => new(vec.W, vec.W, vec.Z, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, Z, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWZZ(this Vector4 vec) => new(vec.W, vec.W, vec.Z, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, Z, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWZW(this Vector4 vec) => new(vec.W, vec.W, vec.Z, vec.W);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, W, X.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWWX(this Vector4 vec) => new(vec.W, vec.W, vec.W, vec.X);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, W, Y.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWWY(this Vector4 vec) => new(vec.W, vec.W, vec.W, vec.Y);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, W, Z.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWWZ(this Vector4 vec) => new(vec.W, vec.W, vec.W, vec.Z);
	/// <summary>
	/// Constructs a new Vector4 with elements from <paramref name="vec"/>: W, W, W, W.
	/// </summary>
	/// <param name="vec">The vector from which to take values.</param>
	/// <returns>The new vector.</returns>
	public static Vector4 WWWW(this Vector4 vec) => new(vec.W, vec.W, vec.W, vec.W);
#endregion
}