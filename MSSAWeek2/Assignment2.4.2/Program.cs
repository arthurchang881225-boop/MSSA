/*
2. Write a C# Sharp program to find the largest of three numbers.

Test Data :

Input the 1st number :25

Input the 2nd number :63

Input the 3rd number :10

Expected Output :

The 2nd Number is the greatest among three
*/


int [] arr = new int[3];
string [] labels = {"1st", "2nd", "3rd"};

for (int i = 0; i < 3; i++)
{
  Console.Write($"Input the {labels[i]} number:");
  arr[i] = int.Parse(Console.ReadLine());
}

int maxIndex = 0;
for (int i = 1; i < 3; i++)
{
  if (arr[i] > arr[maxIndex])
  {
    maxIndex = i;
  }
}

Console.WriteLine($"The {labels[maxIndex]} Number is the greatest among three");