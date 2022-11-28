//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int PowerR(int a, int b)
{
    if(b == 0)
    {
        return 1;
    }
    return a * PowerR(a,b - 1);
}

Console.Write("Введите А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = PowerR(a, b);
Console.Write(result);