using System;

// Напишете програма, която прилага бонус точки към дадени точки в интервала [1..9] чрез прилагане на следните правила:

// -  Ако точките са между 1 и 3, програмата ги умножава по 10.

// -  Ако точките са между 4 и 6, ги умножава по 100.

// -  Ако точките са между 7 и 9, ги умножава по 1000.

// -  Ако точките са 0 или повече от 9, се отпечатва съобщение за грешка.

class Program
{
    static void Main()
    {
        Random randGenerator = new Random();
        int n = randGenerator.Next(1, 10);

        if (n >= 1 && n <= 3)
        {
            Console.WriteLine(n * 10);
        }
        else if (n >= 4 && n <= 6)
        {
            Console.WriteLine(n * 100);
        }
        else if (n >= 7 && n <= 9)
        {
            Console.WriteLine(n * 1000);
        }
        else
        {
            Console.WriteLine("Имате грешка");
        }
    }
}

