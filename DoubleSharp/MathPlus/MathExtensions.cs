namespace DoubleSharp.MathPlus; 

public static class MathExtensions {
	public static float Round(this float x) => MathF.Round(x);
	public static double Round(this double x) => Math.Round(x);
	public static int RoundInt(this float x) => (int) MathF.Round(x);
	public static int RoundInt(this double x) => (int) Math.Round(x);

	public static float Floor(this float x) => MathF.Floor(x);
	public static double Floor(this double x) => Math.Floor(x);
	public static int FloorInt(this float x) => (int) MathF.Floor(x);
	public static int FloorInt(this double x) => (int) Math.Floor(x);

	// I know C# uses Ceiling. Every other language in the world uses ceil.
	// We don't need to be burdened by MS's poor life choices.
	public static float Ceil(this float x) => MathF.Ceiling(x);
	public static double Ceil(this double x) => Math.Ceiling(x);
	public static int CeilInt(this float x) => (int) MathF.Ceiling(x);
	public static int CeilInt(this double x) => (int) Math.Ceiling(x);
	
	public static bool HasBit(this byte v, int bit) => (v & (1U << bit)) != 0;
	public static bool HasBit(this ushort v, int bit) => (v & (1U << bit)) != 0;
	public static bool HasBit(this uint v, int bit) => (v & (1U << bit)) != 0;
	public static bool HasBit(this ulong v, int bit) => (v & (1UL << bit)) != 0;
	
	public static byte WithBit(this byte v, int bit) => (byte) (v | (1U << bit));
	public static ushort WithBit(this ushort v, int bit) => (ushort) (v | (1U << bit));
	public static uint WithBit(this uint v, int bit) => v | (1U << bit);
	public static ulong WithBit(this ulong v, int bit) => v | (1UL << bit);

	public static byte WithoutBit(this byte v, int bit) => (byte) (v & ~(1U << bit));
	public static ushort WithoutBit(this ushort v, int bit) => (ushort) (v & ~(1U << bit));
	public static uint WithoutBit(this uint v, int bit) => v & ~(1U << bit);
	public static ulong WithoutBit(this ulong v, int bit) => v & ~(1UL << bit);

	public static byte SetBit(this byte v, int bit, bool cond) => cond ? (byte) (v | (1U << bit)) : v;
	public static ushort SetBit(this ushort v, int bit, bool cond) => cond ? (ushort) (v | (1U << bit)) : v;
	public static uint SetBit(this uint v, int bit, bool cond) => cond ? v | (1U << bit) : v;
	public static ulong SetBit(this ulong v, int bit, bool cond) => cond ? v | (1UL << bit) : v;
}