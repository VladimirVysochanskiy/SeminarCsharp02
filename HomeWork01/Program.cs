/*
Задача 10:  
 Напишите программу, которая принимает на вход трёхзначное
  число и на выходе показывает вторую цифру этого числа.
* 456 -> 5
* 782 -> 8
* 918 -> 1
*/

Console.Write("Введите трёхзначное число: ");
string? txt = Console.ReadLine();
int number;
if (int.TryParse(txt, out number))
{
    if (number < 0) number *= -1;
    if (number > 99 && number < 1000)
    {
        Console.WriteLine($"Вторая цифра: {(number /10) % 10}");
    }
    else
    {
        Console.WriteLine("Ошибка! Число должно быть трёхзначным");
    }
}
else
{
    Console.WriteLine("Ошибка! Это не число."); 
}
