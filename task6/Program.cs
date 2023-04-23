// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.WriteLine ("Введите трехзначное число: ");

// int number = Convert.ToInt32(Console.ReadLine());
// int lastNumber = 0;

// if (number > 99 && number < 1000 )
// {
//     lastNumber = number % 100 ;
//     Console.Write($"Последеняя числа {number} = {lastNumber}");
// }
// else
// {
//    Console.Write ("Число не трехзначное");
// }
    int number = new Random().Next(100,1000);
    Console.WriteLine(number);

    int fiNumber = number / 100;
    int firNumber = number % 10;
    int result = fiNumber * 10 + firNumber;

    Console.WriteLine(result);