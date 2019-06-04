using System;

// Напишете програма, която по избор на потребителя прочита от конзолата променлива от тип int, double или string. 
// Ако променливата е int или double, трябва да се увеличи с 1. Ако променливата е string, трябва да се прибави накрая символа "*". 
// Отпечатайте получения резултат на конзолата. Използвайте switch конструкция.

class Program
{
    static void Main()
    {
        Console.WriteLine("Kакво ще въвеждате: 0 за цяло число, 1 за дробно число, 2 за низ");
        int choise = int.Parse(Console.ReadLine());

        int inputInt;
        double inputDouble;
        string inputString;

        switch (choise)
        {
            case 0:
                Console.WriteLine("Моля въведете цяло число");
                inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine(inputInt + 1);
                break;
            case 1:
                Console.WriteLine("Моля въведете реално число");
                inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputDouble + 1);
                break;
            case 2:
                Console.WriteLine("Моля въведете низ");
                inputString = Console.ReadLine();
                Console.WriteLine(inputString + "*");
                break;
            default:
                break;
        }
    }
}

