/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */ 

Console.WriteLine("Введи число ");
string s = Console.ReadLine(); 
bool palindrome = true; 
int n = s.Length; 
for (int i = 0; i < n / 2; i++)
{
    if (s[i] != s[n - 1 - i]) 
	palindrome = false;
}
		
if (palindrome == true)
{
			
	Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}