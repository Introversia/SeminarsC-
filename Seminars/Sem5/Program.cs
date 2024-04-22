// 1. Задайте двумерный массив и найдите элементы у которых оба индекса четные.
// Замените такие элементы на их квадраты.

// int[,] CreateMatrix(int rows, int colums, int min, int max)
// {
//     int[,]matrix = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] EvenIndxSquare(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//         }
//     }
//     return matrix;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, colums, min, max);
// PrintMatrix(matrix);
// PrintMatrix(EvenIndxSquare(matrix));


// 2. Задайте двумерный массив и найдите сумму элементов, находящихся на главной диагонали.
// Главная диагональ - это элементы массива, у которых оба индекса одинаковые.

// int[,] CreateMatrix(int rows, int colums, int min, int max)
// {
//     int[,] matrix = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int SumMatrix(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matrix[i, j]; // sum += тоже самое что и sum = sum + matrix
//             }
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximum value of array element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = CreateMatrix(rows, colums, min, max);
// PrintMatrix(matrix);
// Console.WriteLine(SumMatrix(matrix));


// 3. Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из
// средних арифметических значений по строкам двумерного массива.

int[,] CreateMatrix(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] MiddleSum(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum / matrix.GetLength(1);
        sum = 0;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum value of array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(rows, colums, min, max);
PrintMatrix(matrix);
PrintArray(MiddleSum(matrix));