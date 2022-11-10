//  Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int NumLength(int number)
{
    string strNum = Math.Abs(number).ToString();
    int length = strNum.Length;
    return length;
}




Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumLength(number));
