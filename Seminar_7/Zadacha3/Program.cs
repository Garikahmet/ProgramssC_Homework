// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void FillArrayRandom(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetNewArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 ==0)
            {
                array[i, j] = array[i, j] * array[i, j];
                Console.Write(array[i, j] + " ");
            }
            else
            {
                array[i, j] = array[i, j];
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}


Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArrayRandom(array);
Console.WriteLine();
GetNewArray(array);