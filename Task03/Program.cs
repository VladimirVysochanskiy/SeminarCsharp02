/*
Напишите программу, которая будет принимать на вход два числа
и выводить является ли второе число кратным первому. 
Если число 1 не кратно 2, программа выводит остаток от деления.
*/
System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 % num2 != 0)
{
    System.Console.Write("Не кратно, остаток: ");
    System.Console.WriteLine(num1 % num2);
}
else
{
    System.Console.WriteLine("Кратно");
}
//Тернарный оператор. ?:
string result = (num1 % num2 ==0) ? "Кратно" : ($"Не кратно, остаток: {num1 % num2}");
System.Console.WriteLine(result);