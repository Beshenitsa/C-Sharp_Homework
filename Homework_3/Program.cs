///Homework 3 Seminar 3

// Task 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool CheckIfPalindrom(string number)
// {
//     if (number[0] == number[4] || number[1] == number[3])
//     {
//         Console.WriteLine($"Your number: {number} - is a palindrom.");
//         return true;
//     }
//     else
//     {
//         Console.WriteLine($"Your number: {number} - is not a palindrom.");
//         return false;
//     }
// }

// Console.Write("Input your five-digit number, please: ");
// string? number = (Console.ReadLine());

// if (number!.Length == 5)
// {
//     CheckIfPalindrom(number);
// }
// else
//     Console.WriteLine($"Sorry, the number you've input is unsuitable.");

// Task 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double RangeIn3DSpace(double x1, double y1, double x2, double y2, double z1, double z2)
// {
//     double distX = x2 - x1;
//     double distY = y2 - y1;
//     double distZ = z1 - z2;
//     double result = Math.Sqrt(distX * distX + distY * distY + distZ * distZ);
//     return result;
// }

// Console.Write("Inpute value of x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Inpute value of y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Inpute value of z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Inpute value of x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Inpute value of y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Inpute value of z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double rez = Math.Round(RangeIn3DSpace(x1, y1, x2, y2, z1, z2), 2);

// Console.Write($"The range between points 1 and 2 is {rez}.");

// Task 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void TableOfCubes(int Num)
// {
//     int count = 1;
//     while (count <= Num)
//     {
//         Console.WriteLine(count * count * count);
//         count = count + 1;
//     }
// }

// Console.Write("Inpute your number, please: ");
// int Arg = Convert.ToInt32(Console.ReadLine());
// TableOfCubes(Arg);
