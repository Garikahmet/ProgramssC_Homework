/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] GetPairMult(int[] array)
{
// Результирующий массив с произведениями пар
int[] resultArray = null;

// Для массива с четным кол-вом элементов
if (array.Length % 2 == 0)
{
// Инициализация результирующего массива с заданной размерностью
resultArray = new int[array.Length / 2];

// Подсчет произведения пар
for (int i = 0; i <= (resultArray.Length / 2); i++)
{
// Произведение пар
resultArray[i] = array[i] * array[array.Length - i - 1];
}
}
// Для массива с нечетным кол-вом элементов
if (array.Length % 2 == 1)
{
// Инициализация результирующего массива с заданной размерностью
resultArray = new int[(array.Length / 2) + 1];

// Подсчет произведения пар
for (int i = 0; i <= (resultArray.Length / 2 + 1); i++)
{
// Проверка на центральный элемент
if (i == (resultArray.Length / 2) + 1)
{
resultArray[i] = array[i];
}

// Произведение пар
resultArray[i] = array[i] * array[array.Length - i - 1];
}
}

return resultArray;
}

int[] arrayA = new int[4] { 6, 7, 3, 6};
int[] arrayB = new int[5] { 1, 2, 3, 4, 5};

int[] resultA = GetPairMult(arrayA);
int[] resultB = GetPairMult(arrayB);

Console.ReadKey();


