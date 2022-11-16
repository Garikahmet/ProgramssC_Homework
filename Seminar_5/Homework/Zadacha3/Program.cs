/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Случайный массив: ");
PrintArray(numbers);

int minNumber = numbers[0];
int maxNumber = numbers[0];

for (int i = 1; i < numbers; i++)
{
    if (numbers[i] < minNumber)
    {
        minNumber = numbers[i];
    }
}

for (int i = 1; i < numbers; i++)
{
    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
    }
}
int result;
result = maxNumber - minNumber;

Console.WriteLine($"Разница между max и min элементов массива: {result}");