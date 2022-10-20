// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
int a1 = number / 10;
int a2 = number % 10;

Console.WriteLine(number);

if (a1 > a2) Console.WriteLine($"Naibolshaya cifra v chsle :{a1}");
if (a2 > a1) Console.WriteLine($"Naibolshaya cifra v chsle :{a2}");
if (a1 == a2) Console.WriteLine($"Cifri v chsle ravni");

Console.ReadKey();
