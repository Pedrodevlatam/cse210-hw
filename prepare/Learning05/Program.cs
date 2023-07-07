using System;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        // Create instances of Square, Rectangle, and Circle and add them to the list
        Square square = new Square("Red", 5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 3);
        shapes.Add(circle);

        // Iterate through the list of shapes and display their color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.Color);
            Console.WriteLine("Area: " + shape.GetArea());
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
