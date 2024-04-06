// !!This is derived from System.Numerics.Vector2D directly!!
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#pragma warning disable SA1642
#pragma warning disable SA1629

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommunityToolkit.Diagnostics;
// ReSharper disable CompareOfFloatsByEqualityOperator

namespace DoubleSharp.MathPlus;

/// <summary>Represents a vector with two double-precision doubleing-point values.</summary>
public struct Vector2D : IEquatable<Vector2D>, IFormattable {
	/// <summary>The X component of the vector.</summary>
	public double X;

	/// <summary>The Y component of the vector.</summary>
	public double Y;

	/// <summary>Creates a new <see cref="Vector2D" /> object whose two elements have the same value.</summary>
	/// <param name="value">The value to assign to both elements.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector2D(double value) : this(value, value) { }

	/// <summary>Creates a vector whose elements have the specified values.</summary>
	/// <param name="x">The value to assign to the <see cref="X" /> field.</param>
	/// <param name="y">The value to assign to the <see cref="Y" /> field.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector2D(double x, double y) {
		X = x;
		Y = y;
	}

	/// <summary>
	///     Constructs a vector from the given <see cref="ReadOnlySpan{Double}" />. The span must contain at least 2
	///     elements.
	/// </summary>
	/// <param name="values">The span of elements to assign to the vector.</param>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Vector2D(ReadOnlySpan<double> values) {
		if(values.Length < 2) ThrowHelper.ThrowArgumentOutOfRangeException(nameof(values));

		this = Unsafe.ReadUnaligned<Vector2D>(ref Unsafe.As<double, byte>(ref MemoryMarshal.GetReference(values)));
	}

	/// <summary>Gets a vector whose 2 elements are equal to zero.</summary>
	/// <value>A vector whose two elements are equal to zero (that is, it returns the vector <c>(0,0)</c>.</value>
	public static Vector2D Zero {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => default;
	}

	/// <summary>Gets a vector whose 2 elements are equal to one.</summary>
	/// <value>A vector whose two elements are equal to one (that is, it returns the vector <c>(1,1)</c>.</value>
	public static Vector2D One {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(1.0f);
	}

	/// <summary>Gets the vector (1,0).</summary>
	/// <value>The vector <c>(1,0)</c>.</value>
	public static Vector2D UnitX {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(1.0f, 0.0f);
	}

	/// <summary>Gets the vector (0,1).</summary>
	/// <value>The vector <c>(0,1)</c>.</value>
	public static Vector2D UnitY {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => new(0.0f, 1.0f);
	}

	/// <summary>Gets or sets the element at the specified index.</summary>
	/// <param name="index">The index of the element to get or set.</param>
	/// <returns>The the element at <paramref name="index" />.</returns>
	/// <exception cref="ArgumentOutOfRangeException">
	///     <paramref name="index" /> was less than zero or greater than the number
	///     of elements.
	/// </exception>
	public double this[int index] {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		readonly get => index switch {
			0 => X, 1 => Y,
			_ => throw new ArgumentOutOfRangeException(nameof(index))
		};

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set {
			switch(index) {
				case 0:
					X = value;
					break;
				case 1:
					Y = value;
					break;
				default:
					ThrowHelper.ThrowArgumentOutOfRangeException(nameof(index));
					break;
			}
		}
	}

	/// <summary>Adds two vectors together.</summary>
	/// <param name="left">The first vector to add.</param>
	/// <param name="right">The second vector to add.</param>
	/// <returns>The summed vector.</returns>
	/// <remarks>The <see cref="op_Addition" /> method defines the addition operation for <see cref="Vector2D" /> objects.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D operator +(Vector2D left, Vector2D right) {
		return new(
			left.X + right.X,
			left.Y + right.Y
		);
	}

	/// <summary>Divides the first vector by the second.</summary>
	/// <param name="left">The first vector.</param>
	/// <param name="right">The second vector.</param>
	/// <returns>The vector that results from dividing <paramref name="left" /> by <paramref name="right" />.</returns>
	/// <remarks>
	///     The <see cref="Vector2D.op_Division(Vector2D,Vector2D)" /> method defines the division operation for <see cref="Vector2D" />
	///     objects.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D operator /(Vector2D left, Vector2D right) {
		return new(
			left.X / right.X,
			left.Y / right.Y
		);
	}

	/// <summary>Divides the specified vector by a specified scalar value.</summary>
	/// <param name="value1">The vector.</param>
	/// <param name="value2">The scalar value.</param>
	/// <returns>The result of the division.</returns>
	/// <remarks>
	///     The <see cref="Vector2D.op_Division(Vector2D,double)" /> method defines the division operation for <see cref="Vector2D" />
	///     objects.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D operator /(Vector2D value1, double value2) {
		return value1 / new Vector2D(value2);
	}

	/// <summary>Returns a value that indicates whether each pair of elements in two specified vectors is equal.</summary>
	/// <param name="left">The first vector to compare.</param>
	/// <param name="right">The second vector to compare.</param>
	/// <returns>
	///     <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise,
	///     <see langword="false" />.
	/// </returns>
	/// <remarks>
	///     Two <see cref="Vector2D" /> objects are equal if each value in <paramref name="left" /> is equal to the
	///     corresponding value in <paramref name="right" />.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector2D left, Vector2D right) {
		return left.X == right.X
		       && left.Y == right.Y;
	}

	/// <summary>Returns a value that indicates whether two specified vectors are not equal.</summary>
	/// <param name="left">The first vector to compare.</param>
	/// <param name="right">The second vector to compare.</param>
	/// <returns>
	///     <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise,
	///     <see langword="false" />.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector2D left, Vector2D right) {
		return !(left == right);
	}

	/// <summary>Returns a new vector whose values are the product of each pair of elements in two specified vectors.</summary>
	/// <param name="left">The first vector.</param>
	/// <param name="right">The second vector.</param>
	/// <returns>The element-wise product vector.</returns>
	/// <remarks>
	///     The <see cref="Vector2D.op_Multiply(Vector2D,Vector2D)" /> method defines the multiplication operation for
	///     <see cref="Vector2D" /> objects.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D operator *(Vector2D left, Vector2D right) {
		return new(
			left.X * right.X,
			left.Y * right.Y
		);
	}

	/// <summary>Multiplies the specified vector by the specified scalar value.</summary>
	/// <param name="left">The vector.</param>
	/// <param name="right">The scalar value.</param>
	/// <returns>The scaled vector.</returns>
	/// <remarks>
	///     The <see cref="Vector2D.op_Multiply(Vector2D,double)" /> method defines the multiplication operation for
	///     <see cref="Vector2D" /> objects.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D operator *(Vector2D left, double right) {
		return left * new Vector2D(right);
	}

	/// <summary>Multiplies the scalar value by the specified vector.</summary>
	/// <param name="left">The vector.</param>
	/// <param name="right">The scalar value.</param>
	/// <returns>The scaled vector.</returns>
	/// <remarks>
	///     The <see cref="Vector2D.op_Multiply(double,Vector2D)" /> method defines the multiplication operation for
	///     <see cref="Vector2D" /> objects.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D operator *(double left, Vector2D right) {
		return right * left;
	}

	/// <summary>Subtracts the second vector from the first.</summary>
	/// <param name="left">The first vector.</param>
	/// <param name="right">The second vector.</param>
	/// <returns>The vector that results from subtracting <paramref name="right" /> from <paramref name="left" />.</returns>
	/// <remarks>
	///     The <see cref="op_Subtraction" /> method defines the subtraction operation for <see cref="Vector2D" />
	///     objects.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D operator -(Vector2D left, Vector2D right) {
		return new(
			left.X - right.X,
			left.Y - right.Y
		);
	}

	/// <summary>Negates the specified vector.</summary>
	/// <param name="value">The vector to negate.</param>
	/// <returns>The negated vector.</returns>
	/// <remarks>
	///     The <see cref="op_UnaryNegation" /> method defines the unary negation operation for <see cref="Vector2D" />
	///     objects.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D operator -(Vector2D value) {
		return Zero - value;
	}

	/// <summary>Returns a vector whose elements are the absolute values of each of the specified vector's elements.</summary>
	/// <param name="value">A vector.</param>
	/// <returns>The absolute value vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Abs(Vector2D value) {
		return new(
			Math.Abs(value.X),
			Math.Abs(value.Y)
		);
	}

	/// <summary>Adds two vectors together.</summary>
	/// <param name="left">The first vector to add.</param>
	/// <param name="right">The second vector to add.</param>
	/// <returns>The summed vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Add(Vector2D left, Vector2D right) {
		return left + right;
	}

	/// <summary>Restricts a vector between a minimum and a maximum value.</summary>
	/// <param name="value1">The vector to restrict.</param>
	/// <param name="min">The minimum value.</param>
	/// <param name="max">The maximum value.</param>
	/// <returns>The restricted vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Clamp(Vector2D value1, Vector2D min, Vector2D max) {
		// We must follow HLSL behavior in the case user specified min value is bigger than max value.
		return Min(Max(value1, min), max);
	}

	/// <summary>Computes the Euclidean distance between the two given points.</summary>
	/// <param name="value1">The first point.</param>
	/// <param name="value2">The second point.</param>
	/// <returns>The distance.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Distance(Vector2D value1, Vector2D value2) {
		var distanceSquared = DistanceSquared(value1, value2);
		return Math.Sqrt(distanceSquared);
	}

	/// <summary>Returns the Euclidean distance squared between two specified points.</summary>
	/// <param name="value1">The first point.</param>
	/// <param name="value2">The second point.</param>
	/// <returns>The distance squared.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double DistanceSquared(Vector2D value1, Vector2D value2) {
		var difference = value1 - value2;
		return Dot(difference, difference);
	}

	/// <summary>Divides the first vector by the second.</summary>
	/// <param name="left">The first vector.</param>
	/// <param name="right">The second vector.</param>
	/// <returns>The vector resulting from the division.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Divide(Vector2D left, Vector2D right) {
		return left / right;
	}

	/// <summary>Divides the specified vector by a specified scalar value.</summary>
	/// <param name="left">The vector.</param>
	/// <param name="divisor">The scalar value.</param>
	/// <returns>The vector that results from the division.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Divide(Vector2D left, double divisor) {
		return left / divisor;
	}

	/// <summary>Returns the dot product of two vectors.</summary>
	/// <param name="value1">The first vector.</param>
	/// <param name="value2">The second vector.</param>
	/// <returns>The dot product.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Dot(Vector2D value1, Vector2D value2) {
		return value1.X * value2.X
		       + value1.Y * value2.Y;
	}

	/// <summary>Performs a linear interpolation between two vectors based on the given weighting.</summary>
	/// <param name="value1">The first vector.</param>
	/// <param name="value2">The second vector.</param>
	/// <param name="amount">A value between 0 and 1 that indicates the weight of <paramref name="value2" />.</param>
	/// <returns>The interpolated vector.</returns>
	/// <remarks>
	///     <format type="text/markdown"><![CDATA[
	/// The behavior of this method changed in .NET 5.0. For more information, see [Behavior change for Vector2D.Lerp and Vector4.Lerp](/dotnet/core/compatibility/3.1-5.0#behavior-change-for-Vector2Dlerp-and-vector4lerp).
	/// ]]></format>
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Lerp(Vector2D value1, Vector2D value2, double amount) {
		return value1 * (1.0f - amount) + value2 * amount;
	}

	/// <summary>Returns a vector whose elements are the maximum of each of the pairs of elements in two specified vectors.</summary>
	/// <param name="value1">The first vector.</param>
	/// <param name="value2">The second vector.</param>
	/// <returns>The maximized vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Max(Vector2D value1, Vector2D value2) {
		return new(
			value1.X > value2.X ? value1.X : value2.X,
			value1.Y > value2.Y ? value1.Y : value2.Y
		);
	}

	/// <summary>Returns a vector whose elements are the minimum of each of the pairs of elements in two specified vectors.</summary>
	/// <param name="value1">The first vector.</param>
	/// <param name="value2">The second vector.</param>
	/// <returns>The minimized vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Min(Vector2D value1, Vector2D value2) {
		return new(
			value1.X < value2.X ? value1.X : value2.X,
			value1.Y < value2.Y ? value1.Y : value2.Y
		);
	}

	/// <summary>Returns a new vector whose values are the product of each pair of elements in two specified vectors.</summary>
	/// <param name="left">The first vector.</param>
	/// <param name="right">The second vector.</param>
	/// <returns>The element-wise product vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Multiply(Vector2D left, Vector2D right) {
		return left * right;
	}

	/// <summary>Multiplies a vector by a specified scalar.</summary>
	/// <param name="left">The vector to multiply.</param>
	/// <param name="right">The scalar value.</param>
	/// <returns>The scaled vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Multiply(Vector2D left, double right) {
		return left * right;
	}

	/// <summary>Multiplies a scalar value by a specified vector.</summary>
	/// <param name="left">The scaled value.</param>
	/// <param name="right">The vector.</param>
	/// <returns>The scaled vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Multiply(double left, Vector2D right) {
		return left * right;
	}

	/// <summary>Negates a specified vector.</summary>
	/// <param name="value">The vector to negate.</param>
	/// <returns>The negated vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Negate(Vector2D value) {
		return -value;
	}

	/// <summary>Returns a vector with the same direction as the specified vector, but with a length of one.</summary>
	/// <param name="value">The vector to normalize.</param>
	/// <returns>The normalized vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Normalize(Vector2D value) {
		return value / value.Length();
	}

	/// <summary>Returns the reflection of a vector off a surface that has the specified normal.</summary>
	/// <param name="vector">The source vector.</param>
	/// <param name="normal">The normal of the surface being reflected off.</param>
	/// <returns>The reflected vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Reflect(Vector2D vector, Vector2D normal) {
		var dot = Dot(vector, normal);
		return vector - 2.0f * (dot * normal);
	}

	/// <summary>Returns a vector whose elements are the square root of each of a specified vector's elements.</summary>
	/// <param name="value">A vector.</param>
	/// <returns>The square root vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D SquareRoot(Vector2D value) {
		return new(
			Math.Sqrt(value.X),
			Math.Sqrt(value.Y)
		);
	}

	/// <summary>Subtracts the second vector from the first.</summary>
	/// <param name="left">The first vector.</param>
	/// <param name="right">The second vector.</param>
	/// <returns>The difference vector.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2D Subtract(Vector2D left, Vector2D right) {
		return left - right;
	}

	/// <summary>Copies the elements of the vector to a specified array.</summary>
	/// <param name="array">The destination array.</param>
	/// <remarks>
	///     <paramref name="array" /> must have at least two elements. The method copies the vector's elements starting at
	///     index 0.
	/// </remarks>
	/// <exception cref="NullReferenceException"><paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
	/// <exception cref="RankException"><paramref name="array" /> is multidimensional.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly void CopyTo(double[] array) {
		// We explicitly don't check for `null` because historically this has thrown `NullReferenceException` for perf reasons

		if(array.Length < 2) ThrowHelper.ThrowArgumentOutOfRangeException(nameof(array));

		Unsafe.WriteUnaligned(ref Unsafe.As<double, byte>(ref array[0]), this);
	}

	/// <summary>Copies the elements of the vector to a specified array starting at a specified index position.</summary>
	/// <param name="array">The destination array.</param>
	/// <param name="index">The index at which to copy the first element of the vector.</param>
	/// <remarks>
	///     <paramref name="array" /> must have a sufficient number of elements to accommodate the two vector elements. In
	///     other words, elements <paramref name="index" /> and <paramref name="index" /> + 1 must already exist in
	///     <paramref name="array" />.
	/// </remarks>
	/// <exception cref="NullReferenceException"><paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="ArgumentException">The number of elements in the current instance is greater than in the array.</exception>
	/// <exception cref="ArgumentOutOfRangeException">
	///     <paramref name="index" /> is less than zero.
	///     -or-
	///     <paramref name="index" /> is greater than or equal to the array length.
	/// </exception>
	/// <exception cref="RankException"><paramref name="array" /> is multidimensional.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly void CopyTo(double[] array, int index) {
		// We explicitly don't check for `null` because historically this has thrown `NullReferenceException` for perf reasons

		if((uint) index >= (uint) array.Length) ThrowHelper.ThrowArgumentOutOfRangeException(nameof(index));

		if(array.Length - index < 2) ThrowHelper.ThrowArgumentOutOfRangeException(nameof(array));

		Unsafe.WriteUnaligned(ref Unsafe.As<double, byte>(ref array[index]), this);
	}

	/// <summary>Copies the vector to the given <see cref="Span{T}" />.The length of the destination span must be at least 2.</summary>
	/// <param name="destination">The destination span which the values are copied into.</param>
	/// <exception cref="ArgumentException">
	///     If number of elements in source vector is greater than those available in
	///     destination span.
	/// </exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly void CopyTo(Span<double> destination) {
		if(destination.Length < 2) ThrowHelper.ThrowArgumentOutOfRangeException(nameof(destination));

		Unsafe.WriteUnaligned(ref Unsafe.As<double, byte>(ref MemoryMarshal.GetReference(destination)), this);
	}

	/// <summary>
	///     Attempts to copy the vector to the given <see cref="Span{Double}" />. The length of the destination span must
	///     be at least 2.
	/// </summary>
	/// <param name="destination">The destination span which the values are copied into.</param>
	/// <returns>
	///     <see langword="true" /> if the source vector was successfully copied to <paramref name="destination" />.
	///     <see langword="false" /> if <paramref name="destination" /> is not large enough to hold the source vector.
	/// </returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool TryCopyTo(Span<double> destination) {
		if(destination.Length < 2) return false;

		Unsafe.WriteUnaligned(ref Unsafe.As<double, byte>(ref MemoryMarshal.GetReference(destination)), this);
		return true;
	}

	/// <summary>Returns a value that indicates whether this instance and a specified object are equal.</summary>
	/// <param name="obj">The object to compare with the current instance.</param>
	/// <returns>
	///     <see langword="true" /> if the current instance and <paramref name="obj" /> are equal; otherwise,
	///     <see langword="false" />. If <paramref name="obj" /> is <see langword="null" />, the method returns
	///     <see langword="false" />.
	/// </returns>
	/// <remarks>
	///     The current instance and <paramref name="obj" /> are equal if <paramref name="obj" /> is a
	///     <see cref="Vector2D" /> object and their <see cref="X" /> and <see cref="Y" /> elements are equal.
	/// </remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly override bool Equals([NotNullWhen(true)] object? obj) {
		return obj is Vector2D other && Equals(other);
	}

	/// <summary>Returns a value that indicates whether this instance and another vector are equal.</summary>
	/// <param name="other">The other vector.</param>
	/// <returns><see langword="true" /> if the two vectors are equal; otherwise, <see langword="false" />.</returns>
	/// <remarks>Two vectors are equal if their <see cref="X" /> and <see cref="Y" /> elements are equal.</remarks>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly bool Equals(Vector2D other) {
		// This function needs to account for doubleing-point equality around NaN
		// and so must behave equivalently to the underlying double/double.Equals
		return X.Equals(other.X) && Y.Equals(other.Y);
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>The hash code.</returns>
	public readonly override int GetHashCode() {
		return HashCode.Combine(X, Y);
	}

	/// <summary>Returns the length of the vector.</summary>
	/// <returns>The vector's length.</returns>
	/// <altmember cref="LengthSquared" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly double Length() {
		var lengthSquared = LengthSquared();
		return Math.Sqrt(lengthSquared);
	}

	/// <summary>Returns the length of the vector squared.</summary>
	/// <returns>The vector's length squared.</returns>
	/// <remarks>This operation offers better performance than a call to the <see cref="Length" /> method.</remarks>
	/// <altmember cref="Length" />
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public readonly double LengthSquared() {
		return Dot(this, this);
	}

	/// <summary>Returns the string representation of the current instance using default formatting.</summary>
	/// <returns>The string representation of the current instance.</returns>
	/// <remarks>
	///     This method returns a string in which each element of the vector is formatted using the "G" (general) format
	///     string and the formatting conventions of the current thread culture. The "&lt;" and "&gt;" characters are used to
	///     begin and end the string, and the current culture's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property
	///     followed by a space is used to separate each element.
	/// </remarks>
	public readonly override string ToString() {
		return ToString("G", CultureInfo.CurrentCulture);
	}

	/// <summary>
	///     Returns the string representation of the current instance using the specified format string to format
	///     individual elements.
	/// </summary>
	/// <param name="format">A standard or custom numeric format string that defines the format of individual elements.</param>
	/// <returns>The string representation of the current instance.</returns>
	/// <remarks>
	///     This method returns a string in which each element of the vector is formatted using <paramref name="format" />
	///     and the current culture's formatting conventions. The "&lt;" and "&gt;" characters are used to begin and end the
	///     string, and the current culture's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property followed by a space
	///     is used to separate each element.
	/// </remarks>
	/// <related type="Article" href="/dotnet/standard/base-types/standard-numeric-format-strings">
	///     Standard Numeric Format
	///     Strings
	/// </related>
	/// <related type="Article" href="/dotnet/standard/base-types/custom-numeric-format-strings">Custom Numeric Format Strings.</related>
	public readonly string ToString([StringSyntax(StringSyntaxAttribute.NumericFormat)] string? format) {
		return ToString(format, CultureInfo.CurrentCulture);
	}

	/// <summary>
	///     Returns the string representation of the current instance using the specified format string to format
	///     individual elements and the specified format provider to define culture-specific formatting.
	/// </summary>
	/// <param name="format">A standard or custom numeric format string that defines the format of individual elements.</param>
	/// <param name="formatProvider">A format provider that supplies culture-specific formatting information.</param>
	/// <returns>The string representation of the current instance.</returns>
	/// <remarks>
	///     This method returns a string in which each element of the vector is formatted using <paramref name="format" />
	///     and <paramref name="formatProvider" />. The "&lt;" and "&gt;" characters are used to begin and end the string, and
	///     the format provider's <see cref="NumberFormatInfo.NumberGroupSeparator" /> property followed by a space is used to
	///     separate each element.
	/// </remarks>
	/// <related type="Article" href="/dotnet/standard/base-types/custom-numeric-format-strings">Custom Numeric Format Strings</related>
	/// <related type="Article" href="/dotnet/standard/base-types/standard-numeric-format-strings">
	///     Standard Numeric Format
	///     Strings
	/// </related>
	public readonly string ToString([StringSyntax(StringSyntaxAttribute.NumericFormat)] string? format,
		IFormatProvider? formatProvider) {
		var separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

		return $"<{X.ToString(format, formatProvider)}{separator} {Y.ToString(format, formatProvider)}>";
	}
}