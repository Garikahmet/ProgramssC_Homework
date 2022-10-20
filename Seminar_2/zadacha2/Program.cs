/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/ 
int number = new Random().Next(100, 1000);
int first, last, result;
Console.WriteLine(number);

last = number % 10;
first = number / 100;
result = first * 10 + last;

Console.WriteLine($"Sluchainoe chislo: {result}");
Console.ReadKey();