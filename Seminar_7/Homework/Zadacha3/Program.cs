/* Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */



void FillArrayRandom(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = Convert.ToInt32(new Random().Next(0,21));
        }
        Console.WriteLine();
    }
} 

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
int[] summ = new int[m];
FillArrayRandom(array);
PrintArray(array);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        summ[i] += array[j, i];   
    }
    Console.WriteLine();
}
Console.WriteLine();
foreach (double elem in summ)
{          
     Console.WriteLine($"Среднее арифметическое каждого столбца: {Math.Round(elem / m, 2)}");
}