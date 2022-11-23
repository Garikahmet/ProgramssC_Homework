/* Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
Если такой позиции в массиве нет, то сообщить об этом пользователю. Сгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
Использование методов для заполнения массива обязательно. 
Остальное можно реализовать в главной программе.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции. */

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
FillArrayRandom(array);
PrintArray(array);

Console.WriteLine("Введите координату a: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координату b: ");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a > m && b > n)
 {
    Console.WriteLine("такого числа нет");
 }
 
 else
 {
 object c = array.GetValue(a, b);
 Console.WriteLine($"Значение элемента под данными координатами: {c}");
 }

