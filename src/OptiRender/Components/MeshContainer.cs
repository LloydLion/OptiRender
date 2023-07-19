using OptiRender.Visual;

namespace OptiRender.Components
{
	internal class MeshContainer : GameObjectComponent
	{
		public MeshContainer(Mesh mesh)
		{
			Mesh = mesh;
		}


		public Mesh Mesh { get; }
	}
}
