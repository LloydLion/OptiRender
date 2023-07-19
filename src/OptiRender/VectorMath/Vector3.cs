namespace OptiRender.VectorMath
{
	internal readonly record struct Vector3(float X, float Y, float Z)
	{
		public Vector3(float c) : this(c, c, c) { }

		public Vector3(Vector4 vector) : this(vector.X, vector.Y, vector.Z) { }


		public float Magnitude => MathF.Sqrt(SqrMagnitude);

		public float SqrMagnitude => this * this;


		public Vector4 Expand()
		{
			return new Vector4(X, Y, Z, 1);
		}


		public static Vector3 operator +(Vector3 v1, Vector3 v2)
		{
			return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
		}

		public static Vector3 operator *(float scalar, Vector3 vector)
		{
			return new Vector3(scalar * vector.X, scalar * vector.Y, scalar * vector.Z);
		}

		public static float operator *(Vector3 v1, Vector3 v2)
		{
			return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
		}

		public static Vector3 operator -(Vector3 vector) => -1 * vector;

		public static Vector3 operator -(Vector3 v1, Vector3 v2) => v1 + (-v2);

		public static Vector3 operator /(Vector3 v1, float scalar) => (1 / scalar) * v1;

		public static implicit operator Vector3((float, float, float) tuple)
		{
			return new Vector3(tuple.Item1, tuple.Item2, tuple.Item3);
		}
	}
}
