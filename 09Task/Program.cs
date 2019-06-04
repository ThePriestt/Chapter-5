using System;

// Дадени са пет цели числа. Напишете програма, която намира онези подмножества от тях, които имат сума 0. Примери:

// -  Ако са дадени числата {3, -2, 1, 1, 8}, сумата на -2, 1 и 1 е 0.

// -  Ако са дадени числата {3, 1, -7, 35, 22}, няма подмножества със сума 0.

class Program
{
    static void Main()
    {
        int[] numbers = { 3, -2, 1, -1, 8 };

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == 0) 
                {
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                }
            }
        }
    }
}
