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

//Read user input
Console.WriteLine("Input the Roll Number of the student:");
int rollNum = int.Parse(Console.ReadLine());

Console.WriteLine("Input the Name of the Student:");
string studentName = Console.ReadLine();

Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application:");
string marks = Console.ReadLine();
string [] marksArray = marks.Split(' ');

//Parse to int
int physics = int.Parse(marksArray[0]);
int chemistry = int.Parse(marksArray[1]);
int computerApp = int.Parse(marksArray[2]);

Student s = new Student();
s.RollNum = rollNum;
s.StudentName = studentName;
s.Physics = physics;
s.Chemistry = chemistry;
s.ComputerApp = computerApp;

//math calculation
int totalMarks = physics + chemistry + computerApp;
//decimal Percentage = 
//string Division = 


Console.WriteLine($"Roll No : {s.RollNum}");
Console.WriteLine($"Name of Student : {s.StudentName}");
Console.WriteLine($"Marks in Physics : {s.Physics}");
Console.WriteLine($"Marks in Chemistry : {s.Chemistry}");
Console.WriteLine($"Marks in Computer Application : {s.ComputerApp}");
Console.WriteLine($"Total Marks: {totalMarks}");
Console.WriteLine($"Percentage : {Percentage}");
Console.WriteLine($"Division : {Division}");


//create Student class
class Student
{
  public int RollNum;
  public string StudentName;
  public int Physics;
  public int Chemistry;
  public int ComputerApp;
}
