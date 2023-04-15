//Homework 2 Seminar 2

//Task 1.  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecondNumber(int num)
// {
//     int dozens = num % 100;
//     int result = dozens / 10;
//     return result;
// }

// Console.Write("Input your three-digit number, please: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// Number = SecondNumber(Number);
// Console.WriteLine($"The second number is {Number}.");

//Task 2.  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int ThirdNumber(int num)
// {
//     if (num >= 100)
//     {
//         num = num % 10;
//         Console.WriteLine($"The third number is {num}.");
//     }
//     else
//     {
//         Console.WriteLine($"There is no third number.");
//     }
//     return num;
// }

// Console.Write("Input your number, please: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// Number = ThirdNumber(Number);

//Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool IsWeekEndDay(int day)
// {
//     if (day >= 6 && day <= 7)
//     {
//         Console.WriteLine("This is a weekend day.");
//         return true;
//     }
//     else if (day >= 1 && day <= 5)
//     {
//         Console.WriteLine("This is a business day.");
//         return false;
//     }
//     else
//     {
//         Console.WriteLine("Sorry, there is no week day with such number.");
//         return false;
//     }
// }

// Console.Write("Input week day's number, please: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// bool result = IsWeekEndDay(Number);