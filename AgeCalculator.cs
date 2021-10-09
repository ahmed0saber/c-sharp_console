using System;
namespace AgeCalculator
{
class Project1
{
void Main()
{
int year_of_birth;
Console.Write("Enter your birth year : ");
year_of_birth=Convert.ToInt32(Console.ReadLine());
Console.Write("Your age is {0}",(2020-year_of_birth));
}
}
}
