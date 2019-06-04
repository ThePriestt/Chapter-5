using System;

// Напишете програма, която показва знака (+ или -) от произведението на три реални числа, без да го пресмята. Използвайте последователност от if оператори.

class Program
{
    static void Main()
    {
        int a = 32;
        int b = -64;
        int c = 128;
        int negative = 0;

        if (a < 0)
        {
            negative++;
        }
        if (b < 0)
        {
            negative++;
        }
        if (c < 0)
        {
            negative++;
        }

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            if (negative % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}

