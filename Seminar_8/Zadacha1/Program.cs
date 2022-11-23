// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждой строке.

int[,] array = new int[3, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    double tempValue = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 6);
        Console.Write(array[i, j] + " ");

        tempValue = tempValue + array[i, j];
    }
    Console.Write($"Ср. ар. строки = {tempValue / array.GetLength(1)}");
    Console.WriteLine();
}
