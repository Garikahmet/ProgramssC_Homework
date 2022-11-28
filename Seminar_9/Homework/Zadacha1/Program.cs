// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int NaturalNumbers(int n)
{
    if (n == 1)
    {

        return 1;
    }
    Console.Write(n + ",");
    return NaturalNumbers(n - 1);
}

Console.Write("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

int NumbersN = NaturalNumbers(n);
Console.WriteLine(NumbersN);