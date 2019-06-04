using System;

// * Напишете програма, която преобразува дадено число в интервала [0..999] в текст, съответстващ на българското произношение на числото. Примери:

// -  0 → "Нула"

// -  12 → "Дванадесет"

// -  98 → "Деветдесет и осем"

// -  273 → "Двеста седемдесет и три"

// -  400 → "Четиристотин"

// -  501 → "Петстотин и едно"

// -  711 → "Седемстотин и единадесет"

class Program
{
    static void Main()
    {
        // Console.WriteLine("Моля въведете число от 0 до 999");
        // int a = int.Parse(Console.ReadLine());
        string name = "";
        Random randGenerator = new Random();
        int a = randGenerator.Next(0, 100);
        a = 30;
        Console.WriteLine(a);
        int part;
        int remainer;
       
        if (a <= 20 || a == 30 || a == 40 || a == 50 || a == 60 || a == 70 || a == 80 || a == 90)
        {
            name = sayDigit(a);
        }
        else if (a > 20 && a < 100)
        {
            remainer = a % 10;
            part = a - remainer;

            name = sayDigit(part);

            name += " и ";

            name += sayDigit(remainer);
        }


        Console.WriteLine(name);
    }

    static string sayDigit(int a)
    {
        string name = "";

        switch (a)
        {
            case 0:
                name = "Нула";
                break;
            case 1:
                name = "Едно";
                break;
            case 2:
                name = "Две";
                break;
            case 3:
            case 13:
            case 30:
                name = "Три";
                break;
            case 4:
            case 14:
            case 40:
                name = "Четири";
                break;
            case 5:
            case 15:
            case 50:
                name = "Пет";
                break;
            case 6:
            case 16:
            case 60:
                name = "Шест";
                break;
            case 7:
            case 17:
            case 70:
                name = "Седем";
                break;
            case 8:
            case 18:
            case 80:
                name = "Осем";
                break;
            case 9:
            case 19:
            case 90:
                name = "Девет";
                break;
            case 10:
                name = "Десет";
                break;
            case 11:
                name = "Единадесет";
                break;
            case 12:
            case 20:
                name = "Два";
                break;


            default:
                name = "Числото не е в този интервал";
                break;

        }

        if (a > 11 && a < 20)
        {
            name += "надесет";
        }
        else if (a == 20 || a == 30 || a == 40 || a == 50 || a == 60 || a == 70 || a == 80 || a == 90)
        {
            name += "десет";
        }

        return name;
    }
}
