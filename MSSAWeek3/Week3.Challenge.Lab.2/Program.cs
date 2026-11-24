/*
2. Sum digits in string

Given a string, write a method which returns sum of all digits in that string. Assume that string contains only single digits.

Expected input and output

SumDigitsInString("1q2w3e") → 6

SumDigitsInString("L0r3m.1p5um") → 9

SumDigitsInString("") → 0

*/

//access the char in string individually, add it to the sum if that char is a digit

Console.WriteLine(SumDigitsInString("1q2w3e")); //expect 6
Console.WriteLine(SumDigitsInString("L0r3m.1p5um")); //expect 9
Console.WriteLine(SumDigitsInString("")); //expect 0


static int SumDigitsInString(string input)
{
  int sum = 0;
  foreach (char i in input)
  {
    if (char.IsDigit(i)== true)
    {
      sum+= (int)char.GetNumericValue(i);
    }
  }
  return sum;
}


