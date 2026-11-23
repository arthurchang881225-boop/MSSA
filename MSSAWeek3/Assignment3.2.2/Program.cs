/*
2. Write a program in C# Sharp for addition of two Matrices of same size.

Test Data :

Input the size of the square matrix (less than 5): 2

Input elements in the first matrix :

element - [0],[0] : 1

element - [0],[1] : 2

element - [1],[0] : 3

element - [1],[1] : 4

Input elements in the second matrix :

element - [0],[0] : 5

element - [0],[1] : 6

element - [1],[0] : 7

element - [1],[1] : 8

Expected Output:

The First matrix is:

1 2

3 4

The Second matrix is :

5 6

7 8

The Addition of two matrix is :

6 8

10 12

*/


Console.Write("Input the size of the square matrix (less than 5):");
int size = int.Parse(Console.ReadLine());

int [,] a = new int [size, size];
int [,] b = new int [size, size];
int [,] sum = new int [size, size];

Console.WriteLine("Input elements in the first matrix :");
for (int r = 0; r < size; r++)
{
  for (int c = 0; c < size; c++)
  {
    Console.Write($"element - [{r}],[{c}] :");
    a[r,c] = int.Parse(Console.ReadLine());
  }
}


Console.WriteLine("Input elements in the second matrix :");
for (int r = 0; r < size; r++)
{
  for (int c = 0; c < size; c++)
  {
    Console.Write($"element - [{r}],[{c}] :");
    b[r,c] = int.Parse(Console.ReadLine());
  }
}

Console.WriteLine("The First matrix is :");
for (int r = 0; r < size; r++)
{
  for (int c = 0; c < size; c++)
  {
    Console.Write($"{a[r,c]} ");
  }
  Console.WriteLine();
}

Console.WriteLine("The Second matrix is :");
for (int r = 0; r < size; r++)
{
  for (int c = 0; c < size; c++)
  {
    Console.Write($"{b[r,c]} ");
  }
  Console.WriteLine();
}


for (int r = 0; r < size; r++)
{
  for (int c = 0; c < size; c++)
  {
    sum[r,c] = a[r,c] + b[r,c];
  }
}


Console.WriteLine("The Addition of two matrix is :");
for (int r = 0; r < size; r++)
{
  for (int c = 0; c < size; c++)
  {
    Console.Write($"{sum[r,c]} ");
  }
  Console.WriteLine();
}


