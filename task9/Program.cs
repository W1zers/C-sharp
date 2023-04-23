// Напишите программу, которая принимает на вход два числа и проверяет,   
// является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число: ");

int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");

mod(num1,num2);
mod(num2,num1);

void mod(int i, int j)
{
    if ((int)Math.Pow(i, 2) == j)
    {
        Console.WriteLine("да, число " + j + " является квадратом числа " + i);
    }
    else
    {
        Console.WriteLine("число " + j + " не является квадратом числа " + i);
    }
}