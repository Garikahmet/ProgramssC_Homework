/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */ 

Console.Write("Введите число: ");
int dec = Convert.ToInt32(Console.ReadLine());
string ConvertToBin(int a)
{
    string bin1 = Convert.ToString(a);
    string bin2 = "";
    while (a > 0)
    {
        bin1 = (a % 2) + bin2;
        a = a / 2;
    }
    return bin2;
}
Console.WriteLine(ConvertToBin(dec));