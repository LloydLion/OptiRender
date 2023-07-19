namespace OptiRender.Visual
{
	internal record struct Transformation2D(float X, float Y, float Rotation)
	{
		public Transformation2D(float X, float Y) : this(X, Y, 0) { }
	}
}
