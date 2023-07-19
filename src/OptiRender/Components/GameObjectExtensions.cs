namespace OptiRender.Components
{
	internal static class GameObjectExtensions
	{
		public static MeshContainer Mesh(this GameObject gameObject) => gameObject.GetComponent<MeshContainer>();
	}
}
