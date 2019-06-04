using System;

// Напишете програма, която за дадена цифра (0-9), зададена като вход, извежда името на цифрата на български език.

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля въведете число от 0 до 9");
        int a = int.Parse(Console.ReadLine());

        switch (a)
        {
            case 0:
                Console.WriteLine("Нула");
                break;
            case 1:
                Console.WriteLine("Едно");
                break;
            case 2:
                Console.WriteLine("Две");
                break;
            case 3:
                Console.WriteLine("Три");
                break;
            case 4:
                Console.WriteLine("Четири");
                break;
            case 5:
                Console.WriteLine("Пет");
                break;
            case 6:
                Console.WriteLine("Шест");
                break;
            case 7:
                Console.WriteLine("Седем");
                break;
            case 8:
                Console.WriteLine("Осем");
                break;
            case 9:
                Console.WriteLine("Девет");
                break;

            default:
                Console.WriteLine("Числото не е в този интервал");
                break;
                
        }
    }
}

