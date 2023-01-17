/* Задача №1. Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго. 
a = 25, b = 5 -> да  a = 2, b = 10 -> нет  a = 9, b = -3 -> да  
a = -3 b = 9 -> нет */
 
Console.Write("Введите число 1: ");
int numberА = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = int.Parse(Console.ReadLine());
if (numberА == numberB * numberB) 
{
Console.WriteLine("Первое число ЯВЛЯЕТСЯ квадратом второго числа");
 }
else
{
    Console.WriteLine("Первое число НЕ ЯВЛЯЕТСЯ квадратом второго числа");
}