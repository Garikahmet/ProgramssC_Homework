// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumDig(int n)
{
    if(n < 10)
    {
        return n;
    }
    return (n % 10) + SumDig(n / 10);
}

Console.Write("введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumDig(n);
Console.Write(result);
