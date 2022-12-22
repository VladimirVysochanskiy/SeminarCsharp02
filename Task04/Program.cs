﻿// Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0)
{
    if (num % 23 == 0)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}
else
{
    System.Console.WriteLine("Нет");
}

//тернарный оператор.
string result = (num % 7 == 0 && num % 23 == 0) ? "Да" : "Нет";
System.Console.WriteLine(result);