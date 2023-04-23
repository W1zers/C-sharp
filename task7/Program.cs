// Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
// второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите перове число: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int number2 = Convert.ToInt32(Console.ReadLine());

int remains = number1 % number2; 

if(remains == 0)
{
    Console.WriteLine("число 1 кратно числу 2");
}
else
{
    Console.WriteLine($"не кратный, остаток после деления {remains}");
}