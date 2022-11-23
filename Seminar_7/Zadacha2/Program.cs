﻿/* Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

void Convector(int m, int n)
{
    int [,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array [i, j] = i + j;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Convector(m, n);

