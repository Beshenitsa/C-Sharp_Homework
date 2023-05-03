// Homework 5 Seminar 5

// Task 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreatRandomThreeDigitNumbersArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);

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

// void HowManyEvens(int[] array)
// {
//     int count = 0;

//     for (int j = 0; j < array.Length; j++)
//         if (array[j] % 2 == 0)
//             count++;
//     Console.WriteLine($"There are {array.Length} numbers, and {count} of them are even.");
// }


// Console.Write("Input a quantity of elements: ");
// int quantity = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomThreeDigitNumbersArray(quantity);
// ShowArrayButFancy(myArray);
// HowManyEvens(myArray);

// Task 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// int SummOfOddIndexesMeaning(int[] array)
// {
//     int summ = 0;
//     for (int j = 1; j < array.Length; j += 2)
//         summ = summ + array[j];
//     Console.WriteLine($"The summ of odd indexes' meanings is {summ}");
//     return summ;
// }

// void ShowArrayButFancy(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.Write("]");
//     Console.WriteLine();
// }

// Console.Write("Input a quantity of elements: ");
// int quantity = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(quantity, min, max);
// ShowArrayButFancy(myArray);
// SummOfOddIndexesMeaning(myArray);

// Task 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] CreatRandomArrayButDouble(int size)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//         array[i] = Convert.ToDouble(new Random().Next(10, 100)) / 10;

//     return array;
// }

// void ShowArrayButFancyAndDouble(double[] array)
// {
//     Console.Write("[ ");
//     for (int i = 1; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.Write("]");
//     Console.WriteLine();
// }

// double DifferenceBetweenMinAndMax(double[] array)
// {
//     double min = Int32.MaxValue;
//     double max = Int32.MinValue;

//     for (int j = 0; j < array.Length; j++)
//     {
//         if (array[j] > max)
//             max = array[j];
//         if (array[j] < min)
//             min = array[j];
//     }
//     double difference = max - min;
//     Console.WriteLine($"Maximum number is {max}. Mininmum number is {min}. The difference between minimum and maximum number is {difference}.");
//     return difference;
// }

// Console.Write("Input a quantity of elements: ");
// int quantity = Convert.ToInt32(Console.ReadLine());

// double[] myDoubleArray = CreatRandomArrayButDouble(quantity);
// ShowArrayButFancyAndDouble(myDoubleArray);
// DifferenceBetweenMinAndMax(myDoubleArray);
