using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 5.0));
        shapes.Add(new Rectangle("green", 3, 4.0));
        shapes.Add(new Circle("blue", 2.5));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area of the {shape.Color} {shape.GetType().Name} is {shape.GetArea()}.");
        }
    }
}