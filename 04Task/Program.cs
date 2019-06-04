using System;

// Сортирайте 3 реални числа в намаляващ ред. Използвайте вложени if оператори.

class Program
{
    static void Main()
    {
        Random randGenerator = new Random();
        int a = randGenerator.Next(10, 100);
        int b = randGenerator.Next(10, 100);
        int c = randGenerator.Next(10, 100);
        int swap;

        if (a < b)
        {
            if (a > c)
            {
                swap = a;
                a = c;
                c = swap;
            }
            if (b > c)
            {
                swap = b;
                b = c;
                c = swap;
            }
        }
        else
        {
            swap = a;
            a = b;
            b = swap;

            if (a > c)
            {
                swap = a;
                a = c;
                c = swap;
            }

            if (b > c)
            {
                swap = b;
                b = c;
                c = swap;
            }

        }
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
