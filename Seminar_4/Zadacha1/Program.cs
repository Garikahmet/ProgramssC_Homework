// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool IsPolindrome(int numder)
{
    string strNumber - number.ToString();
    
    if (strNumber[0] == strNumber[4] && strNumber[1] == strNumber[3])
    {
        return true;
    }

    return false;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 9999 || number >= 100000)
{
    Console.WriteLine("Некорректное чисто. Введите пятизначное число");
    return;
}

bool isPalindrome = IsPolindrome(number);
Console.WriteLine(ispalindrome);
