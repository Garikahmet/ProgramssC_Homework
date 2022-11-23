/* Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). Округлите значения, генерируемые Random до двух знаков после запятой.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */ 

void FillArrayRandom(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(Math.Round(new Random().NextDouble(), 2));
            Console.Write("{0,6:F2}", array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

FillArrayRandom(array);

