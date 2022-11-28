/* int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
} */ 

int FactorialR(int n)
{
    if (n == 1)
    {

        return 1;
    }
    return n * FactorialR(n - 1);
}

Console.Write("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

int factorialN = FactorialR(n);
Console.WriteLine(factorialN);