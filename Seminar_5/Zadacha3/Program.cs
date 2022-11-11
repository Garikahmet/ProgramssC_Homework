/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет */

bool SearchElement(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            return true;
        }
    }
    return false;
}

int[] array = new int[4] {-4, -8, 8, 2};
int number;

Console.Write("Введите искомое число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.Write(SearchElement(array, number));
