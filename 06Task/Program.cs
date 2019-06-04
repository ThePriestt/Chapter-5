using System;

// Напишете програма, която при въвеждане на коефициентите (a, b и c) на квадратно уравнение: ax2+bx+c, изчислява и извежда неговите реални корени (ако има такива). 
// Квадратните уравнения могат да имат 0, 1 или 2 реални корена.

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля въведете а");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Моля въведете b");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Моля въведете c");
        int c = int.Parse(Console.ReadLine());

        int d = b * b - 4 * a * c;

        if (d < 0)
        {
            Console.WriteLine("Няма реални корени");
        }
        if (d == 0)
        {
            double x = -b / 2.0 * a;
            Console.WriteLine("Уравнението има 1 реален корен x = {0}", x);
        }
        if (d > 0)
        {
            Console.WriteLine("квадратното уравнение има 2 реални корена.");

            double x1 = (-b + Math.Sqrt(d)) / 2 * a;
            Console.WriteLine("x1 = {0}", x1);

            double x2 = (-b - Math.Sqrt(d)) / 2 * a;
            Console.WriteLine("x2 = {0}", x2);


        }
    }
}

