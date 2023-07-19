namespace OptiRender.VectorMath
{
	internal readonly record struct Vector4(float X, float Y, float Z, float W)
	{
		public Vector4(float c) : this(c, c, c, c) { }


		public float Magnitude => MathF.Sqrt(SqrMagnitude);

		public float SqrMagnitude => this * this;


		public static Vector4 operator +(Vector4 v1, Vector4 v2)
		{
			return new Vector4(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z, v1.W + v2.W);
		}

		public static Vector4 operator *(float scalar, Vector4 vector)
		{
			return new Vector4(scalar * vector.X, scalar * vector.Y, scalar * vector.Z, scalar * vector.W);
		}

		public static float operator *(Vector4 v1, Vector4 v2)
		{
			return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z + v1.Z * v2.Z;
		}

		public static Vector4 operator -(Vector4 vector) => -1 * vector;

		public static Vector4 operator -(Vector4 v1, Vector4 v2) => v1 + (-v2);

		public static Vector4 operator /(Vector4 v1, float scalar) => (1 / scalar) * v1;
	}
}
