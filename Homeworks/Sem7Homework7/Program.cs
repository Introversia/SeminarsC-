// 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

string PrintNaturalNumbers(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return m + " " + PrintNaturalNumbers(m + 1, n);
}

Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральные числа от {m} до {n}:");
Console.WriteLine(PrintNaturalNumbers(m, n));


// 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int CalculateAkkermanFunction (int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0) 
    {
        return CalculateAkkermanFunction(m - 1, 1);
    }
    else 
    {
        return CalculateAkkermanFunction(m - 1, CalculateAkkermanFunction(m, n - 1));
    }
}

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m}, {n}) = {CalculateAkkermanFunction(m, n)}");


// 3. Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void ReverseArray (int[] array, int i)
{
    if(i < 0) return;
    Console.Write(array[i] + " ");
    ReverseArray(array, i - 1);
}

int[] array = {16, 10, 7, 1, 5};
ReverseArray(array, array.Length - 1);