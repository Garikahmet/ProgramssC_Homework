// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int GetFactorial(int number)
{
    int res = 1;
    for (int i =1; i <= number; i++)
    {
        res = res *i;
        Console.WriteLine($"Результат итерации {i} равен {res}");
    }
    return res;
}

Console.Write("Введите число А: ");
int number = Convert.ToInt32(ConsoleReadLine());
Console.WriteLine($"Приняли число: {number}");
Console.WriteLine($"Result is: {GetFactorial(number)}");
