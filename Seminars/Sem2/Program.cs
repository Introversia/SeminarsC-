
// 1. Написать метод, который будет возводить число в квадрат и выводить результат в консоль.

// void NumToQuad(int num)
// {
//     System.Console.WriteLine(num * num);
// }

// Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// NumToQuad(a);


// 2. Написать метот, который будет возводить число в квадрат и возвращать число.
// В случае метода, который возвращает какое-либо число должен присутствовать оператор return.

// void NumToQuad(int num)
// {
//     System.Console.WriteLine(num * num);
// }

// int NumToQuadInt(int num)
// {
//     return num * num;
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(NumToQuadInt(a));



// 3. Напишите программу, которая на вход принимает трехзначное число и удаляет вторую цифру этого числа.

// int DeleteSecondDigit(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return sot * 10 + ed;
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//         return 0;
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DeleteSecondDigit(num));


// 4. Напишите программу, которая принимает на вход трехзначное число и возводит вторую цифру этого числа
// в степень, равную третьей цифре. Ed - остаток от деления на 10, который равен 3 цифре числа.
// Dec - остаток числа от деления на 10, предварительно разделенного на 10, что равняется второй цифре этого числа.
// Цикл for закончится когда значение i станет равным третьей цифре числа. Таким образом result это перемножение
// dec (второе число) само на себя ed (третье число) раз.

// int SecondToThirdPower(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         int result = 1;
//         for (int i = 0; i < ed; i++)
//         {
//             result = result * dec;
//         }
//         return result;
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//         return 0;
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SecondToThirdPower(num));


// 5. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно второму, то программа выводит остаток от деления.

// void CheckIfDevides(int num1, int num2)
// {
//     if(num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> yes");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> no, {num1 % num2}");
//     }
// }

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckIfDevides(num1, num2);