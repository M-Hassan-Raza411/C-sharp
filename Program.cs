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


// static int Square(int n)
// {
//     return n * n;
// }
// Console.WriteLine("Enter a number to square: ");

// int number = Convert.ToInt32(Console.ReadLine());

// int result = Square(number);

// Console.WriteLine("The square of " + number + " is: " + result);


//third task creating a bool method to check if a number is even or odd and printing the result while taking input from user

// using static System.Console;

// static bool  IsEven(int n)
// {
//     return n % 2==0 ;
// }

//used " using static System.Console;" to avoid writing Console infonr of WriteLine ReadLine every time

// WriteLine("Enter a number to check if it's even: ");

// int number = Convert.ToInt32(ReadLine());

// bool result = IsEven(number);

// WriteLine("The number is even :" + result);


//fourth task creating a centered star triangle pattern using nested loops and printing the result



// int rows = 7;

//the i loop changes the number of rows
//j loop changes the number of spaces before the stars 
// k loop changes the number of stars in each row

// for (int i = 1; i <= rows; i++)
// {

//     for (int j = 1; j <= rows - i; j++)
//     {
//         Write(" ");
//     }

//     for (int k = 1; k <= i; k++)
//     {
//         Write("* ");
//     }

//     WriteLine();
// }


// used " using static System.Console;" to avoid writing Console infonr of WriteLine ReadLine every time

//made a number guessing game where user has to guess a number between 1 and 10 and program will tell if the guess is correct or not

using static System.Console;

int guessNum= 9;

WriteLine("Guess a number between 1 and 10: ");

int userGuess = Convert.ToInt32(ReadLine());

if (userGuess>10 || userGuess<1)
{
    WriteLine("Please enter a number between 1 and 10.");
}
else if (userGuess == guessNum)
{
    WriteLine("You guessed it right!");
}
else
{
    WriteLine("Sorry, the correct number was " + guessNum);
}