//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// <Возвращаемый тип данных> <наименование метода>(переменные) { тело метода }
// получить номер четверти на плоскости

int GetPointArea(int coordX, int coordY)
{
    int numberArea = 0;
    if (coordX > 0 && coordY > 0)
    {
        numberArea = 1; // вместо этого можно написать return 1
    }

    if (coordX < 0 && coordY > 0)
    {
        numberArea = 2; // вместо этого можно написать return 2
    }

    if (coordX < 0 && coordY < 0)
    {
        numberArea = 3;  // вместо этого можно написать return 3
    }

    if (coordX > 0 && coordY < 0)
    {
        numberArea = 4;   // вместо этого можно написать return 4
    }
    return numberArea;    // вместо этого можно написать return 0 соответственно 
}
Console.WriteLine("Введи X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x, y);  // метод
Console.WriteLine(numberArea);

