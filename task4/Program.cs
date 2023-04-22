using System.Globalization;
// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа. Например, 456->6 782->2 918->8

Console.WriteLine ("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
// if(number < 0)
// {
//  number = -number ;
// }
int lastNumber = 0;

if (number > 99 && number < 1000 )
{
    lastNumber = number % 10 ;
    Console.Write($"Последеняя цифра числа {number} = {lastNumber}");
}
else
{
   Console.Write ("Число не трехзначное");
}