///Homework 1 Seminar 1

///Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 

/*
Console.Write("Input first number, please");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number, please");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.Write(num1 + " is bigger number. And " + num2 + " is smaller number.");
else
    Console.Write(num2 + " is bigger number. And " + num1 + " is smaller number.");
*/

///Task 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input first number, please: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number, please: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number, please: ");
int c1 = Convert.ToInt32(Console.ReadLine());

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max = Max(a1, b1, c1);

Console.WriteLine(max + " is the largest number of the three mentioned.");
*/

///Task 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number, please: ");
int num = Convert.ToInt32(Console.Read());
if (num % 2 == 0) Console.WriteLine("The number is even.");
else Console.WriteLine("The number is odd.");
Console.ReadKey();
*/

///Task 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a number, please: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = (number - number) + 1;

while (current <= number)
{
    if (current % 2 == 0)
        Console.Write(current + " ");
    current++;//current = current + 1;
}
*/