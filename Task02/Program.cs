// напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
/*
int num1 = (number / 100) * 10;
int num2 = number % 10;
Console.WriteLine(num1 + num2);
*/
string txt = Convert.ToString(number);   //Решение строкой
Console.Write(txt[0] + "" + txt[^1]);