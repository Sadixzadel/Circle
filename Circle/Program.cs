using Homework2;

Console.Write("Enter a radius for a circle: ");
double radius = Double.Parse(Console.ReadLine()!);
var circle = new Circle(radius);

var area = circle.GetArea();
Console.WriteLine($"Old area: {area}");

var newRadius = 5.6;
circle.Radius = newRadius;

var newArea = circle.GetArea();
Console.WriteLine($"New area: {newArea}");

