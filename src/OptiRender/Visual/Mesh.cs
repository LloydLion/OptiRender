using OptiRender.VectorMath;

namespace OptiRender.Visual
{
    internal class Mesh
    {
        private readonly Vertex[] _vertices;
        private readonly Triangle[] _triangle;


		public Mesh(Vertex[] vertices, Triangle[] triangle)
		{
			_vertices = vertices;
			_triangle = triangle;
		}


		public record struct Vertex(Vector3 Position)
		{
			public static implicit operator Vertex(Vector3 position)
			{
				return new Vertex(position);
			}

			public static implicit operator Vertex((float, float, float) position) => (Vertex)(Vector3)position;
		}

		public record struct Triangle(ushort Point1Index, ushort Point2Index, ushort Point3Index)
		{
			public static implicit operator Triangle((ushort, ushort, ushort) indexes) => new Triangle(indexes.Item1, indexes.Item2, indexes.Item3);
		}
	}
}
