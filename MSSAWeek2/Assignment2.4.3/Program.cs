/*

3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

Test Data :

Input the value for X coordinate :7

Input the value for Y coordinate :9

Expected Output :

The coordinate point (7,9) lies in the First quadrant.
*/

Console.Write("Input the value for X coordinate:");
int x = int.Parse(Console.ReadLine());

Console.Write("Input the value for Y coordinate:");
int y = int.Parse(Console.ReadLine());

string [] quadrant = {"First", "Second", "Third", "Fourth"};
int index = 0;
switch((x,y))
{
  case (>0, >0):
    index = 0;
    break;
  case (<0, >0):
    index = 1;
    break;
  case (<0, <0):
    index = 2;
    break;
  case (>0, <0):
    index = 3;
    break;
  default:
    Console.WriteLine("The coordinate is lies on an axis, not a quadrant.");
    return;
}

Console.WriteLine($"The coordinate point ({x}, {y}) lies in the {quadrant[index]} quadrant.");