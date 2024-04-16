// 1. Задайте одномерный массив, заполненный случайными числами.
// Определите количество простых чисел в этом массиве.

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

// bool IsPrime(int num)
// {
//     if(num == 1) return false;
//     for (int i = 2; i <= num / 2; i++)
//     {
//         if (num % i == 0) return false;
//     }
//     Console.WriteLine(num);
//     return true;
// }

// int CountPrime(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(IsPrime(array[i])) count++;
//     }
//     return count;
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);
// Console.WriteLine(CountPrime(array));


// 2. Найдите количество чисел, которые заканчиваются на 1 и делятся нацело на 7.

int NumCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 10 == 1 && array[i] % 7 == 0) count++;
    }
    return count;
}

// int [] CreateArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

int[] InputArray()
{
    Console.WriteLine("Input array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Input " + (i + 1) +" element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

int[] array = InputArray();
PrintArray(array);
Console.WriteLine(NumCounter(array));