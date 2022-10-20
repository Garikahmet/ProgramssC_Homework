/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string stringa2 = Convert.ToString(number);

Console.WriteLine($"Вторая цифра этого числа: {stringa2[1]}");