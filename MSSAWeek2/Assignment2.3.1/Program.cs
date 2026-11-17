/*
1. Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). Read the details from same file and print on console.
*/

string path = "/Users/arthur/Desktop/Coding/MSSA/MSSAWeek2/Assignment2.3.1/info.txt";
using (StreamWriter writer = new(path))
{
    writer.WriteLine("Name: John Doe");
    writer.WriteLine("Age: 30");
    writer.WriteLine("Address: 123 Main St, Anytown, USA");
}

using (StreamReader reader = new(path))
{
string text = reader.ReadToEnd();
Console.WriteLine(text);
}
