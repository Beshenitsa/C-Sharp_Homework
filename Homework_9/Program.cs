// Seminar 9 Homeowrk 9


// Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNegativeNumsToOne(int num)
// {
//     Console.Write(num + " ");
//     if (num < 1) ShowNegativeNumsToOne(num + 1);
// }

// ShowNegativeNumsToOne(-5);


// Task 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// void SumOfDigits(int n, int m)
// {
//     int sum = 0;
//     for (int i = n; i <= m; i++)
//         sum += i;
//     Console.WriteLine(sum);
// }
// SumOfDigits(1, 5);


// Task 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// uint A(uint n, uint m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//       if ((n != 0) && (m == 0))
//         return A(n - 1, 1);
//     else
//         return A(n - 1, A(n, m - 1));
// }

// Console.WriteLine(A(2, 0));


