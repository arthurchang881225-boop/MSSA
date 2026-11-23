/*

Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces

*/

Console.WriteLine("Please input a string: ");
string inputData = Console.ReadLine();
int count = CountSpaces(inputData);
Console.WriteLine($"\"{inputData}\" contains {count} spaces");

static int CountSpaces(string inputData)
{
  int count = 0;
  foreach (char c in inputData)
  { 
    if (c == ' ')
    {
      count ++;
    }
  }
  return count;
}


