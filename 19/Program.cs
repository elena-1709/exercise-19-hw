// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

void Rev(int n)
{
        if (n > 10000 && n < 99999)
    {
        Console.WriteLine("ДА! Это палиндром");
    }
    else
    {
        Console.WriteLine ("НЕТ! Это не палиндром");
    }
}

Console.Clear();
Console.WriteLine("Введите пятизначное число:  ");
int n = int.Parse(Console.ReadLine()!);
Rev(n);