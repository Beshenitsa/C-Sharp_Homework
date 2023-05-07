// Homework 7. Seminar 7.

// Task 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void CreateRandom2dArrayButDouble(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void Show2dArray(double[,] array)
// {
//     Console.Write("[ ");
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Console.WriteLine("Input the quantity of row, please: ");
// int quantityOfRows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the quantity of columns, please: ");
// int quantityOfColumns = Convert.ToInt32(Console.ReadLine());
// double[,] my2dArray = new double[quantityOfRows, quantityOfColumns];
// CreateRandom2dArrayButDouble(my2dArray);
// Show2dArray(my2dArray);

// Task 2.  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Input the quantuty of rows: ");
// int quantityOfRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the quantity of columns: ");
// int quantityOfColumns = Convert.ToInt32(Console.ReadLine());
// double[,] randomArray = new double[quantityOfRows, quantityOfColumns];
// Console.Write("Input the position among the row: ");
// int positionRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the position among the column: ");
// int positionColumns = Convert.ToInt32(Console.ReadLine());

// void CreateRandom2dArray(int rows, int columns)
// {
//     int i, j;
//     Random array = new Random();
//     for (i = 0; i < rows; i++)
//     {
//         Console.WriteLine();
//         for (j = 0; j < columns; j++)
//         {
//             randomArray[i, j] = array.NextDouble();
//             Console.Write($"{randomArray[i, j]:F2} ");
//         }
//         Console.WriteLine();
//     }
// }
// CreateRandom2dArray(quantityOfRows, quantityOfColumns);
// if (positionRows < 1 || positionColumns < 1)
//     Console.Write("The position of rows nor columns may not be negative.");
// else if (positionRows <= quantityOfRows + 1 && positionColumns <= quantityOfColumns + 1)
//     Console.Write($"The value of the element is {randomArray[positionRows - 1, positionColumns - 1]:F2}.");
// else Console.Write("There is no such an element in the array.");

// Task 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.WriteLine("Input the quantity of row, please: ");
// int quantityOfRows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the quantity of columns, please: ");
// int quantityOfColumns = Convert.ToInt32(Console.ReadLine());
// int[,] my2dArray = new int[quantityOfRows, quantityOfColumns];
// CreateRandom2dArray(my2dArray);
// Show2dArray(my2dArray);
// Console.Write($"The average meanings each of columns are ");
// CountAverageEveryColumn(my2dArray);

// void CountAverageEveryColumn(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         double average = 0;
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             average = (average + array[i, j]);
//         }
//         average = average / quantityOfColumns;
//         Console.Write($"{average:F2}; ");
//     }
// }


// void CreateRandom2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToInt32(new Random().Next(1, 100)) / 10;
//         }
//     }
// }

// void Show2dArray(int[,] array)
// {
//     Console.Write("[ ");
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }