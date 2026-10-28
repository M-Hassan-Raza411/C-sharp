// Console.WriteLine("nana ");

//first task printing name and age , checking if adult or not and printing numbers from 1 to 10
//learnt variables types and conditional statements and loops

// string name = "hassan raza";

// int age = 20;

// var isAdult = age >= 18 ? "yes" : "no";

// Console.WriteLine("My name is " + name + " and I am " + age + " years old.");

// Console.WriteLine("Am I an adult? " + isAdult);

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }

//second task creating a function to square a number and printing the result while taking input from user

using static System.Console;
static int Square(int n)
{
    return n * n;
}
Console.WriteLine("Enter a number to square: ");

int number = Convert.ToInt32(Console.ReadLine());

int result = Square(number);

Console.WriteLine("The square of " + number + " is: " + result);