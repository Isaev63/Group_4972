﻿// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число некратно первому, 
// то программа выводит остаток от деления.

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
int res = numB % numA;

if (res == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не кратно первому, остаток от деления: " + res);
}