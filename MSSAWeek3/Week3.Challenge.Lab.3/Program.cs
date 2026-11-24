/*
3. Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Input: nums = [2,7,11,15], target = 9

Output: [0,1]

Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

*/


// go through each int in num, if num1+num2 = target. Return the index of num1 and num2

int[] nums = {2,7,11,15};
int target = 9;

for (int i = 0; i < nums.Length; i++)
{
  for (int j = i+1; j < nums.Length; j++)
  {
    if (nums[i] + nums[j] == target)
    {
      Console.WriteLine($"[{i}, {j}]");
      return;
    }
  }

}

