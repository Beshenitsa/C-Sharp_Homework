// Seminar 6 Homework 6

// Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] CreateCustomArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Input the element of array with index {i}, please: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArrayButFancy(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.Write("]");
//     Console.WriteLine();
// }

// int CountPositives(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.Write("Input the quantity of elements in your array, please: ");
// int quantity = Convert.ToInt32(Console.ReadLine());
// int[] myArray;
// myArray = CreateCustomArray(quantity);
// ShowArrayButFancy(myArray);
// Console.WriteLine($"The quantity of positive numbers is {CountPositives(myArray)}.");

// Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Input b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1) / (-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"Two lines intersect at a point with coordinates are X: {x}, Y: {y}");