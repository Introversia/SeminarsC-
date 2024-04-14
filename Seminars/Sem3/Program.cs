
// 1. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// Программа должна выдать ответ: Да/Нет.

// int [] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// bool FindNumInArray(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [] array = CreateArray(size, min, max);
// PrintArray(array);

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindNumInArray(array, num));


// 2. Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. Замените его отрицательные
// элементы на положительные, а положительные элементы на отрицательные.

// int [] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// int[] ChangeArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximum value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);

// PrintArray(ChangeArray(array));


// 3. Найдите произведение пар чисел в одномерном массиве. Результат запишите в новый массив.

// int[] ArrayOfPairs(int[] array)
// {
//     int[] numbers = new int[array.Length / 2];
//     for (int i =0; i < array.Length / 2; i++)
//     {
//         numbers[i] = array[array.Length - i - 1] * array[i];
//     }
//     return numbers;
// }

// int [] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximum value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);
// PrintArray(ArrayOfPairs(array));