Console.Write("How many numbers to print: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers_TailRecursive(n);

void PrintNaturalNumbers_TailRecursive(int n)
{
    if (n > 0)
    {
        Console.Write($"{n} ");
        PrintNaturalNumbers_TailRecursive(n - 1);
    }
}