//Homework 4 Seminar 4

//Task 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Exponentiation(int numberA, int numberB)
// {
//     int result = 1;
//     for (int i = 1; i <= numberB; i++)
//     {
//         result = result * numberA;
//     }
//     return result;
// }

// Console.Write("Please, input the number for exponentiation: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please, input the exponentiation number: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int exponentiation = Exponentiation(numberA, numberB);
// Console.WriteLine($"{numberA} in power of {numberB} equals {exponentiation}.");

//Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Input number N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int numberN)
// {

//     int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++)
//     {
//         advance = numberN - numberN % 10;
//         result = result + (numberN - advance);
//         numberN = numberN / 10;
//     }
//     return result;
// }

// int sumNumber = SumNumber(numberN);
// Console.WriteLine($"Summ of numbers in side of {numberN} is {sumNumber}.");

// Task 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Console.Write("Input eight numbers separated by commas, please: ");
// string? seriesOfNumbers = Console.ReadLine();

// seriesOfNumbers = seriesOfNumbers + ",";

// string RemoveSpaces(string series)
// {
//     string seriesNew = "";
//     for (int i = 0; i < series.Length; i++)
//     {
//         if (series[i] != ' ')
//         {
//             seriesNew += series[i];
//         }
//     }
//     return seriesNew;
// }

// void CheckNumber2(int series)
// {
//     if
//     (series == '0' ||
//      series == '1' ||
//      series == '2' ||
//      series == '3' ||
//      series == '4' ||
//      series == '5' ||
//      series == '6' ||
//      series == '7' ||
//      series == '8' ||
//      series == '9' ||
//      series == ',' ||
//      series == '-')
//     { }
//     else
//     {
//         Console.WriteLine($"Error of input.");
//     }
// }

// int[] ArrayOfNumbers(string newSeries)
// {

//     int[] arrayOfNumbers = new int[1];
//     int j = 0;

//     for (int i = 0; i < newSeries.Length; i++)
//     {
//         string seriesNew1 = "";

//         while (newSeries[i] != ',' && i < newSeries.Length)
//         {
//             seriesNew1 += newSeries[i];
//             CheckNumber2(newSeries[i]);
//             i++;
//         }
//         arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
//         if (i < newSeries.Length - 1)
//         {
//             arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();
//         }
//         j++;
//     }
//     return arrayOfNumbers;
// }

// void PrintArry(int[] coll)
// {
//     int count = coll.Length;
//     int index = 0;
//     Console.Write("[");
//     while (index < count)
//     {
//         Console.Write(coll[index]);
//         index++;
//         if (index < count)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }

// string newSeries = RemoveSpaces(seriesOfNumbers);

// int[] arrayOfNumbers = ArrayOfNumbers(newSeries);

// PrintArry(arrayOfNumbers);
