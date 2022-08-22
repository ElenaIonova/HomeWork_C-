﻿
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.WriteLine($"большее = {num1}");
}
else
{
    Console.WriteLine($"большее = {num2}");
}
/*
*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max=num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
Console.WriteLine($"max = {max}");
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
}
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num) 
{
    Console.Write(current + " ");
    current=current+2;
}
