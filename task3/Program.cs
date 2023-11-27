// Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

int number = new Random().Next(1,100);
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit >= secondDigit)
{
    Console.WriteLine("Наибольшей цифрой числа: " + number + " является цифра:" + firstDigit);
}
else
{
    Console.WriteLine("Наибольшей цифрой числа: " + number + " является цифра:" + secondDigit);
}