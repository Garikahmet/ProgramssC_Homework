// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string NumbersRec(int M, int N)
{
    if (M <= N)
    {
        return NumbersRec(M, N -1) + $"{N}";
    }
    else return String.Empty;
}

Console.Write("Write M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Write N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumbersRec(M, N));
