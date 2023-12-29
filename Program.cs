// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы


// Console.Write("Введите значение M: ");
// int m = int.Parse(Console.ReadLine());

// Console.Write("Введите значение N: ");
// int n = int.Parse(Console.ReadLine());

// PrintNumbersInRange(m, n);

// Console.ReadLine();

// static void PrintNumbersInRange(int m, int n)
// {
//     if (m <= n)
//     {
//         Console.Write($"{m} ");
//         PrintNumbersInRange(m + 1, n);
//     }
// }

//---------------------------------------------------------------------------

// Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Console.Write("Введите значение m: ");
// int m = int.Parse(Console.ReadLine());

// Console.Write("Введите значение n: ");
// int n = int.Parse(Console.ReadLine());

// int result = AckermannFunction(m, n);

// Console.WriteLine($"Значение функции Аккермана для m={m}, n={n}: {result}");

// Console.ReadLine();

// static int AckermannFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return AckermannFunction(m - 1, 1);
//     }
//     else
//     {
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
// }

//-------------------------------------------------------------------------------------

// Задание 3. Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// int[] array = { 1, 2, 3, 4, 5 };

// Console.WriteLine("Элементы массива, начиная с конца:");
// PrintArrayReverse(array, array.Length - 1);

// Console.ReadLine(); 

// static void PrintArrayReverse(int[] array, int index)
// {
//     if (index >= 0)
//     {
//         Console.Write($"{array[index]} ");
//         PrintArrayReverse(array, index - 1);
//     }
// }

//-----------------------------------------------------------------------------
