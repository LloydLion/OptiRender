using OptiRender.Visual.Primitives;

namespace OptiRender.Visual
{
	internal interface IPrimitiveDrawer
	{
		public void Draw(Triangle2D triangle);
	}
}
