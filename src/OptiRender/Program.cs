
using OptiRender;
using OptiRender.Components;
using OptiRender.VectorMath;
using OptiRender.Visual;
using SFML.Graphics;
using SFML.Window;
using System.Diagnostics;
using SFMLColor = SFML.Graphics.Color;

var gameObject = new GameObject();

Mesh.Vertex[] vertices = 
{
	(0, 0, 0),
	(1, 0, 0),
	(1, 1, 0),
	(0, 1, 0),
	(0, 1, 1),
	(1, 1, 1),
	(1, 0, 1),
	(0, 0, 1),
};

Mesh.Triangle[] triangles = 
{
	(0, 2, 1), //face front
	(0, 3, 2),
	(2, 3, 4), //face top
	(2, 4, 5),
	(1, 2, 5), //face right
	(1, 5, 6),
	(0, 7, 4), //face left
	(0, 4, 3),
	(5, 4, 7), //face back
	(5, 7, 6),
	(0, 6, 7), //face bottom
	(0, 1, 6)
};

var mesh = new Mesh(vertices, triangles);

gameObject.AddComponent(new MeshContainer(mesh));

var meshContainer = gameObject.Mesh();


var renderWindow = new RenderWindow(new VideoMode(800, 800, 24), "Test", Styles.Close);


renderWindow.Closed += (s, e) => renderWindow.Close();


var circle = new CircleShape(100, 20)
{
	Position = new SFML.System.Vector2f(20, 20),
	FillColor = SFMLColor.Red
};


var stopwatch = new Stopwatch();
stopwatch.Start();

while (renderWindow.IsOpen)
{
	renderWindow.DispatchEvents();

	renderWindow.Clear(SFMLColor.White);
	renderWindow.Draw(circle);
	renderWindow.Display();

	Console.WriteLine($"Frame time: {stopwatch.ElapsedMilliseconds}");
	stopwatch.Restart();
}
