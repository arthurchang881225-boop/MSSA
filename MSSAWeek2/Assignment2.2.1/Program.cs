/*
Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .

Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.

Inherit square class from shape and change the calculate area logic. Add property like side of square.

Take the input from user to select circle or square and display the calculated area . no hard coded values!

*/
public class Program
{
    public static void Main()
    {
       int choice = 0;
      do
      {
        Console.WriteLine("Choose a shape:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Square");
        Console.WriteLine("3. Exit");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
          case 1:
            Circle circle = new Circle();
            Console.WriteLine("Enter radius of the circle:");
            circle.Radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");
            break;
          case 2:
            Square square = new Square();
            Console.WriteLine("Enter side of the square:");
            square.Side = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area of Square: {square.CalculateArea()}");
            break;
          case 3:
            Console.WriteLine("Exiting the program.");
            break;
          default:
            Console.WriteLine("Invalid choice.");
            break;
        }
      }
      while (choice != 3);
    }
}
public abstract class Shape
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}

