// 1. Вывести значение переменной.

// int a = 5;
// Console.WriteLine(a);

// 2. Запросить значение переменной с помощью метода Console.ReadLine. Вычислить квадрат числа.
// Чтобы конвертировать тип данных string в int, используем Convert.ToInt32.
// Знак $ указывают для того чтобы подставить переменные напрямую и значения этих переменных
// будут интегрированы внутрь текста.

// Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Quad of {a} -> {a * a}");

// 3. Написать программу, которая на вход принимает два целых числа. Вычислить является ли первое число квадратом второго.
// После условий и циклов не ставится знак " ; ". Знак " = " это присваивание значения переменной.
// Знак " == " является оператором равенства.

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2 * num2)
// {
//     System.Console.WriteLine($"{num1} is quad of {num2}"); 
// }
// else
// {
//     System.Console.WriteLine($"{num1} is not quad of {num2}"); 
// }

//  4. Написать программу, которая на вход принимает целое положительное число N, а на выходе показывает все целые числа от -N до N.
//  Команда start++ прибавляет единицу, это тоже самое что и start = start + 1.

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = -n;

// while (start <= n)
// {
//     System.Console.Write(start + " ");
//     start++;
// }

//  5. Напишите программу, которая принимает на вход трехзначное целое число и на выходе показывает сумму первой
//  и последней цифры этого числа.
//  Знак " && " является аналогом союза " и " и подразумевает что все эти условия должны быть выполнены.
//  Знак " || " является аналогом союза " или " и подразумевает что как минимум одно из условий должно быть выполнено.
//  Знак " % " это остаток от деления. Он позволяет отделить последнюю цифру трехзначного числа при делении на 10.
//  Деление на 100 позволяет отделить первую цифру трехзначного числа.
//  Если понадобится отделить цифру, находящуюся в середине, используется формула (num % 100) / 10.

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num >= 100 && num <= 999)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     System.Console.WriteLine($"Sum of {ed} and {sot} -> {ed + sot}");
// }
// else
// System.Console.WriteLine("You input not three-digit number");