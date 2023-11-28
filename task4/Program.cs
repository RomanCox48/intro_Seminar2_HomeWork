using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int N = int.Parse(Console.ReadLine());

        ShowDigitsReverse(N);
    }

    static void ShowDigitsReverse(int n)
    {
        int reversedNumber = 0;

        // Используем цикл для извлечения и вывода цифр в обратном порядке
        while (n > 0)
        {
            int digit = n % 10;
            reversedNumber = reversedNumber * 10 + digit;
            n /= 10;
        }

        // Используем цикл для извлечения и вывода цифр с запятой
        while (reversedNumber > 0)
        {
            int digit = reversedNumber % 10;
            Console.Write(digit);

            // Если это не последняя цифра, выводим запятую
            if (reversedNumber >= 10)
            {
                Console.Write(",");
            }

            reversedNumber /= 10;
        }

        Console.WriteLine();
    }
} 