using System.Numerics;

namespace DoubleSharp.IO; 

public static class BinaryIOExtensions {
	public static Vector2 ReadVector2(this BinaryReader br) =>
		new(br.ReadSingle(), br.ReadSingle());
	public static Vector3 ReadVector3(this BinaryReader br) => 
		new(br.ReadSingle(), br.ReadSingle(), br.ReadSingle());
	public static Vector4 ReadVector4(this BinaryReader br) => 
		new(br.ReadSingle(), br.ReadSingle(), br.ReadSingle(), br.ReadSingle());

	public static void Write(this BinaryWriter bw, Vector2 vec) {
		bw.Write(vec.X);
		bw.Write(vec.Y);
	}
	public static void Write(this BinaryWriter bw, Vector3 vec) {
		bw.Write(vec.X);
		bw.Write(vec.Y);
		bw.Write(vec.Z);
	}
	public static void Write(this BinaryWriter bw, Vector4 vec) {
		bw.Write(vec.X);
		bw.Write(vec.Y);
		bw.Write(vec.Z);
		bw.Write(vec.W);
	}
}