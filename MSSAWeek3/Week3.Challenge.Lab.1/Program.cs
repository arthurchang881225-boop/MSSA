/*
1. Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). Assume that string may consist only of lower-case letters.

Expected input and output

IsPalindrome("eye") → true

IsPalindrome("home") → false

*/

Console.WriteLine(IsPalindrome("eye")); //true
Console.WriteLine(IsPalindrome("home")); //false

static bool IsPalindrome(string input)
{
  for (int i = 0; i < input.Length/2; i++)
  {
    if (input[i] != input[input.Length-1-i])
    {
      return false;
    }
  }
  return true;
}