using OptiRender.Components;

namespace OptiRender
{
	internal class GameObject
	{
		private readonly Dictionary<Type, GameObjectComponent> components = new();


		public GameObject()
		{
		
		}


		public void AddComponent(GameObjectComponent component)
		{
			components.Add(component.GetType(), component);
		}

		public TComponent GetComponent<TComponent>() where TComponent : GameObjectComponent
		{
			return (TComponent)components[typeof(TComponent)];
		}
	}
}
