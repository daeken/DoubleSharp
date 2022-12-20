using System.Numerics;

namespace DoubleSharp.IO; 

/// <summary>DoubleSharp BinaryReader/BinaryWriter Extensions.</summary>
public static class BinaryIOExtensions {
	/// <summary>
	/// Read a Vector2 from this stream. The current position of the stream is advanced by eight.
	/// </summary>
	/// <param name="br">The BinaryReader to read from.</param>
	/// <returns>A Vector2 read from the BinaryReader.</returns>
	public static Vector2 ReadVector2(this BinaryReader br) =>
		new(br.ReadSingle(), br.ReadSingle());
	/// <summary>
	/// Read a Vector3 from this stream. The current position of the stream is advanced by twelve.
	/// </summary>
	/// <param name="br">The BinaryReader to read from.</param>
	/// <returns>A Vector3 read from the BinaryReader.</returns>
	public static Vector3 ReadVector3(this BinaryReader br) => 
		new(br.ReadSingle(), br.ReadSingle(), br.ReadSingle());
	/// <summary>
	/// Read a Vector4 from this stream. The current position of the stream is advanced by sixteen.
	/// </summary>
	/// <param name="br">The BinaryReader to read from.</param>
	/// <returns>A Vector4 read from the BinaryReader.</returns>
	public static Vector4 ReadVector4(this BinaryReader br) => 
		new(br.ReadSingle(), br.ReadSingle(), br.ReadSingle(), br.ReadSingle());

	/// <summary>
	/// Writes a Vector2 to this stream. The current position of the stream is advanced by eight.
	/// </summary>
	/// <param name="bw">The BinaryWriter to write to.</param>
	/// <param name="vec">The Vector2 to write.</param>
	public static void Write(this BinaryWriter bw, Vector2 vec) {
		bw.Write(vec.X);
		bw.Write(vec.Y);
	}
	/// <summary>
	/// Writes a Vector3 to this stream. The current position of the stream is advanced by twelve.
	/// </summary>
	/// <param name="bw">The BinaryWriter to write to.</param>
	/// <param name="vec">The Vector3 to write.</param>
	public static void Write(this BinaryWriter bw, Vector3 vec) {
		bw.Write(vec.X);
		bw.Write(vec.Y);
		bw.Write(vec.Z);
	}
	/// <summary>
	/// Writes a Vector4 to this stream. The current position of the stream is advanced by sixteen.
	/// </summary>
	/// <param name="bw">The BinaryWriter to write to.</param>
	/// <param name="vec">The Vector4 to write.</param>
	public static void Write(this BinaryWriter bw, Vector4 vec) {
		bw.Write(vec.X);
		bw.Write(vec.Y);
		bw.Write(vec.Z);
		bw.Write(vec.W);
	}
}