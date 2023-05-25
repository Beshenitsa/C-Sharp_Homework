// Homework 8 Seminar 8

// Task 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SortEachRowDescendingOrder(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     Show2dArray(array);
// }

// Console.Write("Input a quantioty of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a quantioty of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a minimum possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a maximum possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2dArray(rows, columns, minValue, maxValue);
// Console.WriteLine();
// Show2dArray(myArray);

// SortEachRowDescendingOrder(myArray);

// Task 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.

// void ShowRowNumWithMinSummElements(int[,] array)
// {
//     int minSum = int.MaxValue;
//     int rowNum = 0;
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             temp += array[i, j];
//         }
//         if (temp < minSum)
//         {
//             minSum = temp;
//             rowNum = i;
//         }
//     }
//     Console.WriteLine($"The row number {rowNum} has the smallest sum of its elements - {minSum}");
//     Console.WriteLine();
// }

// ShowRowNumWithMinSummElements(myArray);

// Task 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Write("Input a quantioty of rows: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a quantioty of columns: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a minimum possible value: ");
// int minValue2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a maximum possible value: ");
// int maxValue2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray2 = Create2dArray(rows2, columns2, minValue, maxValue);
// Console.WriteLine();
// Show2dArray(myArray2);

// void MultiplyTwo2DMatrices(int[,] arrayA, int[,] arrayB)
// {
//     if (arrayA.GetLength(1) == arrayB.GetLength(0))
//     {
//         int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//         for (int i = 0; i < arrayC.GetLength(0); i++)
//         {
//             for (int j = 0; j < arrayC.GetLength(1); j++)
//             {
//                 int product = 0;
//                 for (int k = 0; k < arrayA.GetLength(1); k++)
//                 {
//                     product += arrayA[i, k] * arrayB[k, j];
//                 }
//                 arrayC[i, j] = product;
//             }
//         }
//         Show2dArray(arrayC);
//     }
//     else
//         Console.WriteLine("The amount of rows in the first array has to be equal to the amount of columns in the second one.");
// }

// MultiplyTwo2DMatrices(myArray, myArray2);

// Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2

// int[,,] Create3dArray(int rows, int columns, int deepness)
// {
//     int[,,] array = new int[rows, columns, deepness];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             for (int k = 0; k < deepness; k++)
//                 array[i, j, k] = new Random().Next(10, 100);
//     return array;
// }

// void Show3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//                 Console.Write(array[i, j, k] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ShowArrayButFancy(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.Write("]");
//     Console.WriteLine();
// }

// int[] Turn3dArrayIntoJustArray(int[,,] arr)
// {
//     int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
//     for (int i = 0, h = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 temp[h] = arr[i, j, k];
//                 h++;
//             }
//         }
//     }
//     ShowArrayButFancy(temp);
//     return temp;
// }

// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a quantity of deepness: ");
// int deepness = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3dArray(rows, columns, deepness);
// Console.WriteLine();
// Show3dArray(myArray);
// Turn3dArrayIntoJustArray(myArray);

// Task 5. Напишите программу, которая заполнит спирально массив 4 на 4.

// void CreateSpiralMatrix()
// {
//     int n = 4;
//     int[,] spiralArray = new int[n, n];

//     int temp = 1;
//     int i = 0;
//     int j = 0;

//     while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
//     {
//         spiralArray[i, j] = temp;
//         temp++;
//         if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
//             j++;
//         else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
//             i++;
//         else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
//             j--;
//         else
//             i--;
//     }
//     Show2dArray(spiralArray);
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// CreateSpiralMatrix();


