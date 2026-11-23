/*
5. Create a function that finds the index of a given item in the array

Examples

Search([1, 5, 3], 5) ➞ 1

Search([9, 8, 3], 3) ➞ 2

Search([1, 2, 3], 4) ➞ -1

Notes

If the item is not present, return -1.

*/
Console.WriteLine(Search(new int[] { 1, 5, 3 }, 5)); // expect 1
Console.WriteLine(Search(new int[] { 9, 8, 3 }, 3)); // expect 2
Console.WriteLine(Search(new int[] { 1, 2, 3 }, 4)); // expect -1


static int Search(int[] arr, int target)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == target)
    {
      return i;
    }
  }
  return -1;
}


