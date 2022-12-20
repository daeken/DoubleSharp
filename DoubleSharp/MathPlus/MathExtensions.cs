namespace DoubleSharp.MathPlus; 

/// <summary>DoubleSharp Math Extensions.</summary>
public static class MathExtensions {
	/// <summary>
	/// Rounds a single-precision floating-point value to the nearest integral value, and rounds midpoint values to the nearest even number.
	/// </summary>
	/// <param name="x">A single-precision floating-point number to be rounded.</param>
	/// <returns>The integer nearest <paramref name="x"/>. If the fractional component of <paramref name="x"/> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a `Single` instead of an integral type.</returns>
	public static float Round(this float x) => MathF.Round(x);
	/// <summary>
	/// Rounds a double-precision floating-point value to the nearest integral value, and rounds midpoint values to the nearest even number.
	/// </summary>
	/// <param name="x">A double-precision floating-point number to be rounded.</param>
	/// <returns>The integer nearest <paramref name="x"/>. If the fractional component of <paramref name="x"/> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a `Double` instead of an integral type.</returns>
	public static double Round(this double x) => Math.Round(x);
	/// <summary>
	/// Rounds a single-precision floating-point value to the nearest integral value, and rounds midpoint values to the nearest even number. Returns the integral value.
	/// </summary>
	/// <param name="x">A single-precision floating-point number to be rounded.</param>
	/// <returns>The integer nearest <paramref name="x"/>. If the fractional component of <paramref name="x"/> is halfway between two integers, one of which is even and the other odd, then the even number is returned.</returns>
	public static int RoundInt(this float x) => (int) MathF.Round(x);
	/// <summary>
	/// Rounds a double-precision floating-point value to the nearest integral value, and rounds midpoint values to the nearest even number. Returns the integral value.
	/// </summary>
	/// <param name="x">A double-precision floating-point number to be rounded.</param>
	/// <returns>The integer nearest <paramref name="x"/>. If the fractional component of <paramref name="x"/> is halfway between two integers, one of which is even and the other odd, then the even number is returned.</returns>
	public static int RoundInt(this double x) => (int) Math.Round(x);

	/// <summary>
	/// Returns the largest integral value less than or equal to the specified single-precision floating-point number.
	/// </summary>
	/// <param name="x">A single-precision floating-point number.</param>
	/// <returns>The largest integral value less than or equal to <paramref name="x"/>. If <paramref name="x"/> is equal to NaN, NegativeInfinity, or PositiveInfinity, that value is returned.</returns>
	public static float Floor(this float x) => MathF.Floor(x);
	/// <summary>
	/// Returns the largest integral value less than or equal to the specified double-precision floating-point number.
	/// </summary>
	/// <param name="x">A double-precision floating-point number.</param>
	/// <returns>The largest integral value less than or equal to <paramref name="x"/>. If <paramref name="x"/> is equal to NaN, NegativeInfinity, or PositiveInfinity, that value is returned.</returns>
	public static double Floor(this double x) => Math.Floor(x);
	/// <summary>
	/// Returns the largest integral value less than or equal to the specified single-precision floating-point number.
	/// </summary>
	/// <param name="x">A single-precision floating-point number.</param>
	/// <returns>The largest integral value less than or equal to <paramref name="x"/>.</returns>
	public static int FloorInt(this float x) => (int) MathF.Floor(x);
	/// <summary>
	/// Returns the largest integral value less than or equal to the specified double-precision floating-point number.
	/// </summary>
	/// <param name="x">A double-precision floating-point number.</param>
	/// <returns>The largest integral value less than or equal to <paramref name="x"/>.</returns>
	public static int FloorInt(this double x) => (int) Math.Floor(x);

	// I know C# uses Ceiling. Every other language in the world uses ceil.
	// We don't need to be burdened by MS's poor life choices.
	
	/// <summary>
	/// Returns the smallest integral value that is greater than or equal to the specified single-precision floating-point number.
	/// </summary>
	/// <param name="x">A single-precision floating-point number.</param>
	/// <returns>The smallest integral value that is greater than or equal to <paramref name="x"/>. If <paramref name="x"/> is equal to NaN, NegativeInfinity, or PositiveInfinity, that value is returned. Note that this method returns a Single instead of an integral type.</returns>
	public static float Ceil(this float x) => MathF.Ceiling(x);
	/// <summary>
	/// Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.
	/// </summary>
	/// <param name="x">A double-precision floating-point number.</param>
	/// <returns>The smallest integral value that is greater than or equal to <paramref name="x"/>. If <paramref name="x"/> is equal to NaN, NegativeInfinity, or PositiveInfinity, that value is returned. Note that this method returns a Single instead of an integral type.</returns>
	public static double Ceil(this double x) => Math.Ceiling(x);
	/// <summary>
	/// Returns the smallest integral value that is greater than or equal to the specified single-precision floating-point number.
	/// </summary>
	/// <param name="x">A single-precision floating-point number.</param>
	/// <returns>The smallest integral value that is greater than or equal to <paramref name="x"/>.</returns>
	public static int CeilInt(this float x) => (int) MathF.Ceiling(x);
	/// <summary>
	/// Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.
	/// </summary>
	/// <param name="x">A double-precision floating-point number.</param>
	/// <returns>The smallest integral value that is greater than or equal to <paramref name="x"/>.</returns>
	public static int CeilInt(this double x) => (int) Math.Ceiling(x);
	
	/// <summary>
	/// Returns true if the specified bit is set in the input value.
	/// </summary>
	/// <param name="v">The value in which to check the bit.</param>
	/// <param name="bit">The position of the bit to check.</param>
	/// <returns>A boolean representing the presence or absence of bit position <paramref name="bit"/> in <paramref name="v"/>.</returns>
	public static bool HasBit(this byte v, int bit) => (v & (1U << bit)) != 0;
	/// <inheritdoc cref="HasBit(byte, int)" />
	public static bool HasBit(this ushort v, int bit) => (v & (1U << bit)) != 0;
	/// <inheritdoc cref="HasBit(byte, int)" />
	public static bool HasBit(this uint v, int bit) => (v & (1U << bit)) != 0;
	/// <inheritdoc cref="HasBit(byte, int)" />
	public static bool HasBit(this ulong v, int bit) => (v & (1UL << bit)) != 0;
	
	/// <summary>
	/// Sets a bit in the value to 1.
	/// </summary>
	/// <param name="v">The initial value.</param>
	/// <param name="bit">The position of the bit to set.</param>
	/// <returns>The value <paramref name="v"/> with bit <paramref name="bit"/> set to 1.</returns>
	public static byte WithBit(this byte v, int bit) => (byte) (v | (1U << bit));
	/// <inheritdoc cref="WithBit(byte, int)" />
	public static ushort WithBit(this ushort v, int bit) => (ushort) (v | (1U << bit));
	/// <inheritdoc cref="WithBit(byte, int)" />
	public static uint WithBit(this uint v, int bit) => v | (1U << bit);
	/// <inheritdoc cref="WithBit(byte, int)" />
	public static ulong WithBit(this ulong v, int bit) => v | (1UL << bit);

	/// <summary>
	/// Sets a bit in the value to 0.
	/// </summary>
	/// <param name="v">The initial value.</param>
	/// <param name="bit">The position of the bit to set.</param>
	/// <returns>The value <paramref name="v"/> with bit <paramref name="bit"/> set to 0.</returns>
	public static byte WithoutBit(this byte v, int bit) => (byte) (v & ~(1U << bit));
	/// <inheritdoc cref="WithoutBit(byte, int)" />
	public static ushort WithoutBit(this ushort v, int bit) => (ushort) (v & ~(1U << bit));
	/// <inheritdoc cref="WithoutBit(byte, int)" />
	public static uint WithoutBit(this uint v, int bit) => v & ~(1U << bit);
	/// <inheritdoc cref="WithoutBit(byte, int)" />
	public static ulong WithoutBit(this ulong v, int bit) => v & ~(1UL << bit);

	/// <summary>
	/// Sets a bit in the value to 1 when the condition is true and 0 when the condition is false.
	/// </summary>
	/// <param name="v">The initial value.</param>
	/// <param name="bit">The position of the bit to set.</param>
	/// <param name="cond">The condition on which to set/unset the bit.</param>
	/// <returns>The value <paramref name="v"/> with bit <paramref name="bit"/> set to 1 when <paramref name="cond"/> is true and 0 when <paramref name="cond"/> is false.</returns>
	public static byte SetBit(this byte v, int bit, bool cond) => cond ? (byte) (v | (1U << bit)) : (byte) (v & ~(1U << bit));
	/// <inheritdoc cref="SetBit(byte, int, bool)" />
	public static ushort SetBit(this ushort v, int bit, bool cond) => cond ? (ushort) (v | (1U << bit)) : (ushort) (v & ~(1U << bit));
	/// <inheritdoc cref="SetBit(byte, int, bool)" />
	public static uint SetBit(this uint v, int bit, bool cond) => cond ? v | (1U << bit) : v & ~(1U << bit);
	/// <inheritdoc cref="SetBit(byte, int, bool)" />
	public static ulong SetBit(this ulong v, int bit, bool cond) => cond ? v | (1UL << bit) : v & ~(1UL << bit);
}