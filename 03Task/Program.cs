using System;

// Напишете програма, която намира най-голямото по стойност число, измежду три дадени числа.

class Program
{
    static void Main(string[] args)
    {
        int a = 62;
        int b = 88;
        int c = 96;

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}

