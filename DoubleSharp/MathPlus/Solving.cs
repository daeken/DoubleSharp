using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Optimization;
using MathNet.Numerics.Optimization.ObjectiveFunctions;

namespace DoubleSharp.MathPlus;

/// <summary>
/// Provides methods for numerical root finding.
/// </summary>
public static class Solving {
	/// <summary>
	/// Uses the BfgsMinimizer to find the root of a given function.
	/// </summary>
	/// <param name="func">The function to minimize.</param>
	/// <param name="initialGuess">The initial guess for the parameter.</param>
	/// <param name="lowerBound">The lower parameter bound.</param>
	/// <param name="upperBound">The upper parameter bound.</param>
	/// <param name="gradientTolerance">The gradient tolerance.</param>
	/// <param name="parameterTolerance">The parameter tolerance.</param>
	/// <param name="functionProgressTolerance">The function progress tolerance.</param>
	/// <param name="maxIterations">The maximum number of iterations.</param>
	/// <returns>The estimated input for a root.</returns>
	public static double FindRoot(
			Func<double, double> func, 
			double initialGuess, 
			double lowerBound = double.NegativeInfinity, 
			double upperBound = double.PositiveInfinity,
			double gradientTolerance = 1e-8,
			double parameterTolerance = 1e-8,
			double functionProgressTolerance = 1e-8,
			int maxIterations = 1000
		) {
		var optimizer = new BfgsMinimizer(gradientTolerance, parameterTolerance, functionProgressTolerance,
			maxIterations);
		var objective = ObjectiveFunction.Value(v => func(v[0]));
		var objectiveWithGradient = new ForwardDifferenceGradientObjectiveFunction(objective,
			Vector<double>.Build.DenseOfArray(new[] { lowerBound }),
			Vector<double>.Build.DenseOfArray(new[] { upperBound }));
		var result = optimizer.FindMinimum(objectiveWithGradient,
			Vector<double>.Build.DenseOfArray(new[] { initialGuess }));
		return result.MinimizingPoint[0];
	}
	
	/// <inheritdoc cref="FindRoot(Func{double,double},double,double,double,double,double,double,int)" />
	public static (double X, double Y) FindRoot(
		Func<double, double, double> func, 
		(double X, double Y) initialGuess, 
		(double X, double Y)? lowerBound = null, 
		(double X, double Y)? upperBound = null,
		double gradientTolerance = 1e-8,
		double parameterTolerance = 1e-8,
		double functionProgressTolerance = 1e-8,
		int maxIterations = 1000
	) {
		var optimizer = new BfgsMinimizer(gradientTolerance, parameterTolerance, functionProgressTolerance,
			maxIterations);
		var objective = ObjectiveFunction.Value(v => func(v[0], v[1]));
		lowerBound ??= (double.NegativeInfinity, double.NegativeInfinity);
		upperBound ??= (double.PositiveInfinity, double.PositiveInfinity);
		var objectiveWithGradient = new ForwardDifferenceGradientObjectiveFunction(objective,
			Vector<double>.Build.DenseOfArray(new[] { lowerBound.Value.X, lowerBound.Value.Y }),
			Vector<double>.Build.DenseOfArray(new[] { upperBound.Value.X, upperBound.Value.Y }));
		var result = optimizer.FindMinimum(objectiveWithGradient,
			Vector<double>.Build.DenseOfArray(new[] { initialGuess.X, initialGuess.Y }));
		return (result.MinimizingPoint[0], result.MinimizingPoint[1]);
	}
	
	/// <inheritdoc cref="FindRoot(Func{double,double},double,double,double,double,double,double,int)" />
	public static (double X, double Y, double Z) FindRoot(
		Func<double, double, double, double> func, 
		(double X, double Y, double Z) initialGuess, 
		(double X, double Y, double Z)? lowerBound = null, 
		(double X, double Y, double Z)? upperBound = null,
		double gradientTolerance = 1e-8,
		double parameterTolerance = 1e-8,
		double functionProgressTolerance = 1e-8,
		int maxIterations = 1000
	) {
		var optimizer = new BfgsMinimizer(gradientTolerance, parameterTolerance, functionProgressTolerance,
			maxIterations);
		var objective = ObjectiveFunction.Value(v => func(v[0], v[1], v[2]));
		lowerBound ??= (double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
		upperBound ??= (double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);
		var objectiveWithGradient = new ForwardDifferenceGradientObjectiveFunction(objective,
			Vector<double>.Build.DenseOfArray(new[] { lowerBound.Value.X, lowerBound.Value.Y, lowerBound.Value.Z }),
			Vector<double>.Build.DenseOfArray(new[] { upperBound.Value.X, upperBound.Value.Y, lowerBound.Value.Z }));
		var result = optimizer.FindMinimum(objectiveWithGradient,
			Vector<double>.Build.DenseOfArray(new[] { initialGuess.X, initialGuess.Y, initialGuess.Z }));
		return (result.MinimizingPoint[0], result.MinimizingPoint[1], result.MinimizingPoint[2]);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	static double Square(double x) => x * x;

	/// <summary>
	/// Reduces multiple outputs from a function via the sum of squares method.
	/// </summary>
	/// <param name="func">The function to wrap.</param>
	/// <param name="inputWeight">The weights to provide to the input(s).</param>
	/// <param name="outputWeight">The weights to provide to the output(s).</param>
	/// <returns>A function taking a single input and returning a single output.</returns>
	public static Func<double, double> SumOfSquares(
		Func<double, (double X, double Y)> func,
		double inputWeight = 1,
		(double X, double Y)? outputWeight = null
	) {
		var (wx, wy) = outputWeight ?? (1, 1);
		return i => {
			var (x, y) = func(i / inputWeight);
			return Square(x * wx) + Square(y * wy);
		};
	}
	
	/// <inheritdoc cref="SumOfSquares(Func{double,ValueTuple{double,double}},double,Nullable{ValueTuple{double,double}})" />
	public static Func<double, double> SumOfSquares(
		Func<double, (double X, double Y, double Z)> func,
		double inputWeight = 1,
		(double X, double Y, double Z)? outputWeight = null
	) {
		var (wx, wy, wz) = outputWeight ?? (1, 1, 1);
		return i => {
			var (x, y, z) = func(i / inputWeight);
			return Square(x * wx) + Square(y * wy) + Square(z * wz);
		};
	}
	
	/// <inheritdoc cref="SumOfSquares(Func{double,ValueTuple{double,double}},double,Nullable{ValueTuple{double,double}})" />
	public static Func<double, double> SumOfSquares(
		Func<double, (double X, double Y, double Z, double W)> func,
		double inputWeight = 1,
		(double X, double Y, double Z, double W)? outputWeight = null
	) {
		var (wx, wy, wz, ww) = outputWeight ?? (1, 1, 1, 1);
		return i => {
			var (x, y, z, w) = func(i / inputWeight);
			return Square(x * wx) + Square(y * wy) + Square(z * wz) + Square(w * ww);
		};
	}
	
	/// <inheritdoc cref="SumOfSquares(Func{double,ValueTuple{double,double}},double,Nullable{ValueTuple{double,double}})" />
	public static Func<double, double, double> SumOfSquares(
		Func<double, double, (double X, double Y)> func,
		(double X, double Y)? inputWeight = null,
		(double X, double Y)? outputWeight = null
	) {
		var (iwx, iwy) = inputWeight ?? (1, 1);
		var (wx, wy) = outputWeight ?? (1, 1);
		return (ix, iy) => {
			var (x, y) = func(ix / iwx, iy / iwy);
			return Square(x * wx) + Square(y * wy);
		};
	}
	
	/// <inheritdoc cref="SumOfSquares(Func{double,ValueTuple{double,double}},double,Nullable{ValueTuple{double,double}})" />
	public static Func<double, double, double> SumOfSquares(
		Func<double, double, (double X, double Y, double Z)> func,
		(double X, double Y)? inputWeight = null,
		(double X, double Y, double Z)? outputWeight = null
	) {
		var (iwx, iwy) = inputWeight ?? (1, 1);
		var (wx, wy, wz) = outputWeight ?? (1, 1, 1);
		return (ix, iy) => {
			var (x, y, z) = func(ix / iwx, iy / iwy);
			return Square(x * wx) + Square(y * wy) + Square(z * wz);
		};
	}
	
	/// <inheritdoc cref="SumOfSquares(Func{double,ValueTuple{double,double}},double,Nullable{ValueTuple{double,double}})" />
	public static Func<double, double, double> SumOfSquares(
		Func<double, double, (double X, double Y, double Z, double W)> func,
		(double X, double Y)? inputWeight = null,
		(double X, double Y, double Z, double W)? outputWeight = null
	) {
		var (iwx, iwy) = inputWeight ?? (1, 1);
		var (wx, wy, wz, ww) = outputWeight ?? (1, 1, 1, 1);
		return (ix, iy) => {
			var (x, y, z, w) = func(ix / iwx, iy / iwy);
			return Square(x * wx) + Square(y * wy) + Square(z * wz) + Square(w * ww);
		};
	}
	
	/// <inheritdoc cref="SumOfSquares(Func{double,ValueTuple{double,double}},double,Nullable{ValueTuple{double,double}})" />
	public static Func<double, double, double, double> SumOfSquares(
		Func<double, double, double, (double X, double Y)> func,
		(double X, double Y, double Z)? inputWeight = null,
		(double X, double Y)? outputWeight = null
	) {
		var (iwx, iwy, iwz) = inputWeight ?? (1, 1, 1);
		var (wx, wy) = outputWeight ?? (1, 1);
		return (ix, iy, iz) => {
			var (x, y) = func(ix / iwx, iy / iwy, iz / iwz);
			return Square(x * wx) + Square(y * wy);
		};
	}
	
	/// <inheritdoc cref="SumOfSquares(Func{double,ValueTuple{double,double}},double,Nullable{ValueTuple{double,double}})" />
	public static Func<double, double, double, double> SumOfSquares(
		Func<double, double, double, (double X, double Y, double Z)> func,
		(double X, double Y, double Z)? inputWeight = null,
		(double X, double Y, double Z)? outputWeight = null
	) {
		var (iwx, iwy, iwz) = inputWeight ?? (1, 1, 1);
		var (wx, wy, wz) = outputWeight ?? (1, 1, 1);
		return (ix, iy, iz) => {
			var (x, y, z) = func(ix / iwx, iy / iwy, iz / iwz);
			return Square(x * wx) + Square(y * wy) + Square(z * wz);
		};
	}
	
	/// <inheritdoc cref="SumOfSquares(Func{double,ValueTuple{double,double}},double,Nullable{ValueTuple{double,double}})" />
	public static Func<double, double, double, double> SumOfSquares(
		Func<double, double, double, (double X, double Y, double Z, double W)> func,
		(double X, double Y, double Z)? inputWeight = null,
		(double X, double Y, double Z, double W)? outputWeight = null
	) {
		var (iwx, iwy, iwz) = inputWeight ?? (1, 1, 1);
		var (wx, wy, wz, ww) = outputWeight ?? (1, 1, 1, 1);
		return (ix, iy, iz) => {
			var (x, y, z, w) = func(ix / iwx, iy / iwy, iz / iwz);
			return Square(x * wx) + Square(y * wy) + Square(z * wz) + Square(w * ww);
		};
	}
}