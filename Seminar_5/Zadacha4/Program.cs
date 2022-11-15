/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */ 


int[] array = new int[123];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 999);
    Console.Write(array[i] + " ");
}

int Count(int[] array, int a1, int a2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > a1 && array[i] < a2)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите искомое меньшее число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое меньшее число: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество нужных наи элементов = {Count(array, a1, a2)}");




