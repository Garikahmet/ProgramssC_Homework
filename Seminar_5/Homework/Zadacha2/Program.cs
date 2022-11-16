/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100,100);
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
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("Случайный массив: ");
PrintArray(numbers);

int sum = 0;
<<<<<<< HEAD
for (int i = 0; i < size; i++)
{
    if (i % 2 != 0)
=======
for (int i = 0; i < 10; i++)
{
    if (numbers[i] % 2 != 0)
>>>>>>> b5dde58bb07da5aac8d06972f3d0591127ab4455
    {
        sum = sum + numbers[i];
    }
}

Console.WriteLine($"Сумма чисел на нечетных позициях: {sum}");
