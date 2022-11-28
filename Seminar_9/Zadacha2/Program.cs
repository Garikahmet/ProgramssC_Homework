// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int FactorialR(int n)
{
    if (n == 1)
    {

        return 1;
    }
    Console.Write(n + ",");
    return FactorialR(n - 1);
}

Console.Write("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

int factorialN = FactorialR(n);
Console.WriteLine(factorialN);