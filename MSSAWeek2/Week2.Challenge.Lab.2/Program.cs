/*
2. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.

*/


public class Program
{
  public static void Main()
  {
    string correctUserId = "admin";
    string correctPassword = "password";
    int attempts = 0;
    
    while (attempts < 3)
    {
      Console.WriteLine("Enter User ID:");
      string userId = Console.ReadLine();
      Console.WriteLine("Enter Password:");
      string password = Console.ReadLine();

      if (userId == correctUserId && password == correctPassword)
      {
        Console.WriteLine("Access granted.");
        break;
      }
      else
      {
        attempts++;
        Console.WriteLine($"Incorrect User ID or Password. {3 - attempts} attempts left.");
      }
    }
    if (attempts == 3)
    {
      Console.WriteLine("Access denied. Too many failed attempts.");
    }
  }
}



