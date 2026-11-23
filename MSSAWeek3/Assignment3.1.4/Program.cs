/*

Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.

For e.g: Input : [0,2,1,1,9,1,1]

Output: [0,2,0,0,9,1,1]

*/

Console.Write("Input array:");
string input = Console.ReadLine() ?? "";

int[] arr = input.Split(',').Select(int.Parse).ToArray();

ReplaceFirstPair(arr);

Console.WriteLine($"Output: [{string.Join(",", arr)}]");

static void ReplaceFirstPair(int[] arr)
{
  for (int i = 0; i < arr.Length - 1; i++)
  {
    if (arr[i] == 1 && arr[i+1] == 1)
    {
      arr[i] = 0;
      arr[i+1] = 0;
      break;
    }
  }
}
