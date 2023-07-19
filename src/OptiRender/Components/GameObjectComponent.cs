namespace OptiRender.Components
{
	internal abstract class GameObjectComponent
	{
		private GameObject? _owner;


		public GameObjectComponent()
		{

		}


		protected GameObject Owner => _owner ?? throw new InvalidOperationException("Component is not initialized");


		public void Initialize(GameObject owner)
		{
			_owner = owner;
		}
	}
}
