﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

using System.Numerics;

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Вычисляем факториал
BigInteger Factorial(int num)
{
    BigInteger res = 1;
    for (int i = 2; i <= num; ++i)
        res *= i;
    return res;
}

int num = ReadData("Введите число: ");
BigInteger res = Factorial(num);
PrintResult("Факториал числа: " + res);
