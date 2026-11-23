/*
3. Create a console application to overload "+" and "-" operator for adding the areas of 2 circles and getting their area difference respectively.

*/

class Circle
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Area is computed from the radius: PI * r^2
    public double Area => Math.PI * Radius * Radius;

    // c1 + c2 -> sum of the two areas
    public static double operator +(Circle a, Circle b)
    {
        return a.Area + b.Area;
    }

    // c1 - c2 -> difference of the two areas (absolute)
    public static double operator -(Circle a, Circle b)
    {
        return Math.Abs(a.Area - b.Area);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Input the radius of the first circle: ");
        Circle c1 = new Circle(double.Parse(Console.ReadLine()!));

        Console.Write("Input the radius of the second circle: ");
        Circle c2 = new Circle(double.Parse(Console.ReadLine()!));

        Console.WriteLine();
        Console.WriteLine($"Area of first circle  (r = {c1.Radius}): {c1.Area:F2}");
        Console.WriteLine($"Area of second circle (r = {c2.Radius}): {c2.Area:F2}");
        Console.WriteLine();
        Console.WriteLine($"Sum of areas        (c1 + c2): {c1 + c2:F2}");
        Console.WriteLine($"Difference of areas (c1 - c2): {c1 - c2:F2}");
    }
}
