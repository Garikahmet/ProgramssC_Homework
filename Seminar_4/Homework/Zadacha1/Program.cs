/*Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Для решения задания использование цикла for является обязательным условием. 
Не использовать встроенный метод возведения в степень.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
 

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int step = numberA;

for (int i = 1; i < numberB; i++)
{
    step = step * numberA;
}
Console.WriteLine("A в степени B равно: " + step);
