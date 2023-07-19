using OptiRender.VectorMath;

namespace OptiRender
{
	internal class Scene
	{
		public record struct Object(Scene Scene, GameObject GameObject, Vector3 Position);
	}
}
