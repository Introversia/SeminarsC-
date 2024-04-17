// 1. Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

// while (true) // Бесконечный цикл
// {
//     Console.Write("Введите любое число или 'q' для выхода: ");
//     string input = Console.ReadLine(); // Чтение строки ввода пользователя

//     if (input == "q")
//     { // Проверка на ввод 'q' для выхода
//         Console.WriteLine("[STOP]");
//         break;
//     }

//     int number;
//     if (int.TryParse(input, out number))
//     {// Проверка, является ли ввод числом{
//         int sum = 0;
//         while (number > 0)
//         { // Вычисление суммы цифр числа
//             sum += number % 10; // Добавление последней цифры к сумме
//             number /= 10; // Удаление последней цифры из числа
//         }

//         if (sum % 2 == 0)
//         { // Проверка, является ли сумма цифр четной
//             Console.WriteLine("[STOP]");
//             break;
//         }
//     }

//     else // Если ввод не является числом и не 'q', повторить запрос
//     {
//         Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q': ");
//     }
// }

// Или:

// string input = "";
//     int num;
//     bool exit = true;
//     while (exit)
//     {
//         input = Input();
//         if (int.TryParse(input, out num))
//             exit = !(num % 2 == 0);
//         else
//         if (input == "q")
//             exit = false;
//     }
//     string Input()
//     {
//         Console.WriteLine("Введите число или символ 'q' для выхода");
//         return Console.ReadLine();
//     }


// 2. Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

//     int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//         Console.Write($"{array[i]} ");
//     }
//     return array;
// }

// int GetCount(int[] arr)  
// {
//     int count = 0;                        
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0) 
//         {
//             count++; 
//         }
//     }
//     return count;
// }

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] res = CreateArray(n);
// Console.WriteLine();
// Console.WriteLine($"Количество четных чисел в массиве равно {GetCount(res)}");


// 3. Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 100);        
//     }
//     return array;
// }

// void ShowArray(int[] col)
// {
//     foreach (int item in col)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// int[] GetInvertedArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
//     }
//     return array;
// } 

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(n);
// Console.WriteLine("Исходный массив:");
// ShowArray(array);

// int[] array2 = GetInvertedArray(array);
// Console.WriteLine($"Массив после преобразования (перевернутый):");
// ShowArray(array2);