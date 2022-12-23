//Задача 13:  
//Напишите программу, которая выводит третью цифру заданного
//числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// ##################################################

/*
//Вариант решения в строке.
Console.Clear();
Console.Write("Введите число: ");  
string? txt = Console.ReadLine();
int number;
if (int.TryParse(txt, out number))
{
    if (txt[0] == '-' && txt.Length >= 4)
    {
        Console.WriteLine($"Третья цифра: {txt[3]}");
    }
    else if (txt.Length >=3)
    {
        Console.WriteLine($"Третья цифра: {txt[2]}");
    }
    else
    {
        Console.WriteLine("Третей цифры нет");
    }
}
else
{
    Console.WriteLine("Ошибка! Это не число."); 
}
*/
// ####################################################

//Вариант решения с целочисленным делением.
Console.Clear();
Console.Write("Введите число: ");  
string? txt = Console.ReadLine();
int number;
if (int.TryParse(txt, out number))
{
    if (number < 0) number *= -1;
    if (number / 100 == 0)
    {
        Console.WriteLine("Третей цифры нет");
    }
    else 
    {
        while (number > 999)
        {
            number /= 10;
        }
        Console.WriteLine($"Третья цифра: {number % 10}");
    }
}
else
{
    Console.WriteLine("Ошибка! Это не число."); 
}