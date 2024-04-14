﻿
// 1. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 7 == 0 && n % 23 == 0)
{
    Console.Write($"Число {n} кратно одновременно 7 и 23");
}
else
{
    Console.Write($"Число {n} не кратно одновременно 7 и 23");
}


// 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причем X не равна 0
// и Y не равна 0, и выдает номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.Write($"Как минимум одно из значений равно нулю. Введите значение больше нуля");
}
if (x > 0 && y > 0)
{
    Console.Write($"Точка находится в первой четверти");
}
if (x < 0 && y > 0)
{
    Console.Write($"Точка находится во второй четверти");
}
if (x < 0 && y < 0)
{
    Console.Write($"Точка находится в третьей четверти");
}
if (x > 0 && y < 0)
{
    Console.Write($"Точка находится в четвертой четверти");
}


// 3. Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

Console.WriteLine("Введите число из отрезка [10, 99]");
int a = Convert.ToInt32(Console.ReadLine());

int b = a / 10;
int c = a % 10;

if (b > c)
{
    Console.Write($"Первая цифра больше и равна {b}");
}
if (c > b)
{
    Console.Write($"Вторая цифра больше и равна {c}");
}
if (b == c)
{
    Console.Write($"Цифры числа одинаковы и равны {b}");
}


// 4. Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите натуральное число N ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 0)
{
    Console.Write($"{n % 10} ");
    n = n / 10;
}