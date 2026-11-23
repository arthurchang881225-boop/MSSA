/*

If year is leap

Given a year as integer, write a method that checks if year is leap.

Expected input and output

IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false

*/

Console.WriteLine ("Enter a year to check if it's a leap year");
int year = int.Parse(Console.ReadLine());

Console.WriteLine(IfYearIsLeap(year));


static bool IfYearIsLeap (int year)
{
  if (year % 400 == 0)
  {
    return true;
  }
  else if (year % 100 == 0)
  {
    return false;
  }
  else if (year % 4 == 0)
  {
    return true;
  }
  else
  {
    return false;
  }

}

