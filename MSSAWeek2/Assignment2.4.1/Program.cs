/*
1. Write a program in C# Sharp to find the sum of all array elements.

Test Data :

Input the number of elements to be stored in the array :3

Input 3 elements in the array :

element - 0 : 2

element - 1 : 5

element - 2 : 8

Expected Output :

Sum of all elements stored in the array is : 15

*/


Console.Write("Input the number of elements to be stored in the array: ");
int count = int.Parse(Console.ReadLine());

Console.WriteLine($"Input {count} elements in the array: ");
int [] arr = new int[count];
for (int i = 0; i < count; i++)
{
  Console.Write($"element - {i}: ");
  arr[i] = int.Parse(Console.ReadLine());
}


int sum = 0;
foreach (int n in arr)
{
  sum += n;
}

Console.WriteLine($"Sum of all elements stored in the array is: {sum}");


