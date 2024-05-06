// 1. Задайте двумерный массив символов (тип char [,]). Создайте строку из символов этого массива.

// string CharOfString(char[,] arr)
// {
//     string st = "";

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.WriteLine(i);
//             st += arr[i, j];
//         }
//     }
//     return st;
// }


// char[,] chars = new char[,]
// {
//     { 'a', '1' },
//     { 'c', 'd' }
// };
// Console.WriteLine(CharOfString(chars));
// CharOfString(chars);


// 2. Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string text = "gdsKGF34!-0";
// string result = text.ToLower();
// Console.Write(result);


// 3. Задайте произвольную строку. Выясните, является ли она палиндромом.

// using System.Text;
// Console.InputEncoding = Encoding.Unicode;
// Console.OutputEncoding = Encoding.Unicode;

// bool IsPalindrom(string str)
// {
//     bool a = false;
//     bool b = false;
//     int count = 0;
//     for (int i = 0; i < str.Length / 2; i++)
//     {
//         if (str[i] == str[str.Length - i - 1])
//         {
//             a = true;
//             if (a)
//             {
//                 count++;
//             }
//         }
//     }
//     if (count == str.Length / 2)
//     {
//         b = true;
//     }
//     return b;
// }

// void Print(bool str)
// {
//     if (str)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }

// string str = "окно";
// bool isPalindrom = IsPalindrom(str);
// Print(isPalindrom);
