/*
1. Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
Temp 0-10 then Freezing weather
Temp 11-20 then Very Cold weather
Temp 21-35 then Cold weather
Temp 36-50 then Normal in Weather
Temp 51-65 then Its Hot
Temp 66-80 then Its Very Hot
Test Data :
67
Expected Output :
Its very hot.

*/

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter temperature in Fahrenheit:");
    int usertemp = int.Parse(Console.ReadLine());

    switch (usertemp)
    {
      case int temp when (temp <= 10 && temp >= 0):
        Console.WriteLine("Freezing weather");
        break;
      case int temp when (temp >= 11 && temp <= 20):
        Console.WriteLine("Very Cold weather");
        break;
      case int temp when (temp >= 21 && temp <= 35):
        Console.WriteLine("Cold weather");
        break;
      case int temp when (temp >= 36 && temp <= 50):
        Console.WriteLine("Normal in Weather");
        break;
      case int temp when (temp >= 51 && temp <= 65):
        Console.WriteLine("Its Hot");
        break;
      case int temp when (temp >= 66 && temp <= 80):
        Console.WriteLine("Its Very Hot");
        break;
      default:
        Console.WriteLine("Temperature out of range.");
        break;
    }
  }
}











