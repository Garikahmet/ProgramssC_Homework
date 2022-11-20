/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

void FillArrayRandomNumbers(double[] numbers)
{
    for(double i = 0; i < numbers.Length; i++)
    {
        numbers[(int)i] = new Random().NextDouble();
    }
 return;  
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(double i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[(int)i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
double size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[(int)size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Случайный массив: ");
PrintArray(numbers);

double minNumber = numbers[0];
double maxNumber = numbers[0];

for (double i = 1; i > numbers.Length; i++)
{
    if (numbers[(int)i] < minNumber)
    {
        minNumber = numbers[(int)i];
    }  
}

for (double i = 1; i < numbers.Length; i++)
{
    if (numbers[(int)i] > maxNumber)
    {
        maxNumber = numbers[(int)i];
    }
}
double result;
result = maxNumber - minNumber;

Console.WriteLine($"Разница между max и min элементов массива: {Math.Round(result, 2)}");