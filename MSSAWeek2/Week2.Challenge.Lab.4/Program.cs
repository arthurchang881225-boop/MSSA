/*
4. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. (May use a struct / class to represent the student)
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90

Expected Output :
Roll No : 784
Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First

*/

Console.WriteLine("Input the Roll Number of the student:");
int rollNum = int.Parse(Console.ReadLine());

Console.WriteLine("Input the Name of the Student:");
string studentName = Console.ReadLine();

Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application:");
string marks = Console.ReadLine();
string [] marksArray = marks.Split(' ');

int count = 0
foreach mark in marksArray
{
  int i = int.Parse(marksArray[count]);
  count++;
}

class Student
{
  public int rollNum
  public string studentName
  public int 
}





