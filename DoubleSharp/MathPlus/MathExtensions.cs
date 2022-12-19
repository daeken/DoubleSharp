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

	public static float Ceil(this float x) => MathF.Ceiling(x);
	public static double Ceil(this double x) => Math.Ceiling(x);
	public static int CeilInt(this float x) => (int) MathF.Ceiling(x);
	public static int CeilInt(this double x) => (int) Math.Ceiling(x);
}