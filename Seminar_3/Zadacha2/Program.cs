// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string GetCoordArea(int chetvert)
{
string coords = "";
if (chetvert == 1)
{
    coords = "x >0, y > 0";
}
if (chetvert == 2)
{
    coords = "x < 0, y > 0";
}
if (chetvert == 3)
{
    coords = "x < 0, y < 0";
}
if (chetvert == 4)
{
    coords = "x > 0, y < 0";
}
return coords;
}

Console.WriteLine("Введи номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());

string coords = GetCoordArea(n);  // метод
Console.WriteLine(coords);

