

// 1. Напишите программу, которая на ввод принимает два числа и выводит какое число больше, а какое меньше.

using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже

if (firstNumber == secondNumber)
{
       Console.WriteLine("числа равны");
}
else if (firstNumber > secondNumber)
{
    Console.WriteLine("первое число больше");
}
else
{
    Console.WriteLine("второе число больше");
}
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 3;
            secondNumber = 6;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}



//  2. Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выводит максимальное
//  из этих чисел.

using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
      // Введите свое решение ниже

    if (a >= b && a >= c)
    {
        return a;
    }

    if (b >= a && b >= c)
    {
        return b;
    }

    else
    {
        return c;
    }
}

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 8;
           b = 20;
           c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}


// 3. Напишите программу, которая принимает на ввод число и определяет, является ли оно четным.

using System;

class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже

if ((number % 2) == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}

    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 10;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}



// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N включительно.

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже

int i = 1;

while (i <= number)

    if (i % 2 == 0)
    {
        Console.Write(i + " ");
        i++;
    }
    else
    {
        i++;
    }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 10;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}  
