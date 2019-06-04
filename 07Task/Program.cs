using System;

//  Напишете програма, която намира най-голямото по стойност число измежду дадени 5 числа.

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        Console.WriteLine(max);
    }
}

