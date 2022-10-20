//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}