using OptiRender.VectorMath;

namespace OptiRender
{
	internal class Transform
	{
		private Vector3 _position;


		public Transform()
		{

		}


		public Vector3 Position => _position;


		public void Translate(Vector3 translationVector)
		{
			_position += translationVector;
		}
	}
}
