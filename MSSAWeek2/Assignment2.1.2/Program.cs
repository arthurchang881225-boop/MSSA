/*
2. Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). Write overloaded methods with logic and give choice to user to call different methods :
a. Add(int num1, int num2)
b. Add(decimal num1, decimal num2, decimal num3)
c. Multiply(float num1, float num2)
d. Multiply( float num1, float num2, float num3)
Declare these methods as public and static.

*/

public static class Program
{
  public static void Main()
  {
    Console.WriteLine("Choose an operation:");
    Console.WriteLine("1. Add two integers");
    Console.WriteLine("2. Add three decimals");
    Console.WriteLine("3. Multiply two floats");
    Console.WriteLine("4. Multiply three floats");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
      case 1:
        Console.WriteLine("Enter first integer:");
        int int1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second integer:");
        int int2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {Maths.Add(int1, int2)}");
        break;
      case 2:
        Console.WriteLine("Enter first decimal:");
        decimal dec1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter second decimal:");
        decimal dec2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter third decimal:");
        decimal dec3 = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {Maths.Add(dec1, dec2, dec3)}");
        break;
      case 3:
        Console.WriteLine("Enter first float:");
        float float1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter second float:");
        float float2 = float.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {Maths.Multiply(float1, float2)}");
        break;
      case 4:
        Console.WriteLine("Enter first float:");
        float f1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter second float:");
        float f2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter third float:");
        float f3 = float.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {Maths.Multiply(f1, f2, f3)}");
        break;
      default:
        Console.WriteLine("Invalid choice.");
        break;
    }
  }
}
public static class Maths
{
  public static int Add(int num1, int num2)
  {
    return num1 + num2;
  }
  public static decimal Add(decimal num1, decimal num2, decimal num3)
  {
    return num1 + num2 + num3;
  }
  public static float Multiply(float num1, float num2)
  {
    return num1 * num2;
  }
  public static float Multiply(float num1, float num2, float num3)
  {
    return num1 * num2 * num3;
  }
}


