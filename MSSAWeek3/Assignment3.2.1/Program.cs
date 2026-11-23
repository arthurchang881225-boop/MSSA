/*
1. Create a 2D array to store integers and print them in matrix format with proper formatting.

e. g:

| 2 | 3 | 4 |

| 1 | 4 | 6 |

*/


int [,] matrix =
{
  {2, 3, 4},
  {1, 4, 6}
};

int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);

for (int r = 0; r < rows; r++)
{
  Console.Write("|");
  for (int c = 0; c < columns; c++)
  {
    Console.Write($"{matrix[r, c], 2} |");
  }
  Console.WriteLine();
}
