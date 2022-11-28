// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + SumNumbers(m, n -1);
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(m , n);
Console.WriteLine($"Сумма элементов от {m} до {n} = {result}");