namespace DoubleSharp.Random; 

public static class Rng {
	static int SeedSalt;
	static readonly ThreadLocal<System.Random> LocalRandom =
		new(() => new(unchecked(Environment.TickCount * Interlocked.Increment(ref SeedSalt))));
	static System.Random Random => LocalRandom.Value!;

	public static int Next() => Random.Next();
	public static int Next(int maxValue) => Random.Next(maxValue);
	public static int Next(int minValue, int maxValue) => Random.Next(minValue, maxValue);

	public static long NextInt64() => Random.NextInt64();
	public static long NextInt64(int maxValue) => Random.NextInt64(maxValue);
	public static long NextInt64(int minValue, int maxValue) => Random.NextInt64(minValue, maxValue);

	public static void NextBytes(byte[] buffer) => Random.NextBytes(buffer);
	public static void NextBytes(Span<byte> buffer) => Random.NextBytes(buffer);

	public static double NextDouble() => Random.NextDouble();
	public static double NextSingle() => Random.NextSingle();
}