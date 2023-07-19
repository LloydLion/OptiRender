namespace OptiRender.VectorMath
{
	internal readonly record struct Matrix4x4(Vector4 I, Vector4 J, Vector4 K, Vector4 L)
	{
		public static Vector4 operator *(Matrix4x4 matrix, Vector4 vector)
		{
			return vector.X * matrix.I + vector.Y * matrix.J + vector.Z * matrix.K + vector.W * matrix.L;
		}

		public static Matrix4x4 operator *(Matrix4x4 m1, Matrix4x4 m2)
		{
			return new Matrix4x4(m1 * m2.I, m1 * m2.J, m1 * m2.K, m1 * m2.L);
		}
	}
}
