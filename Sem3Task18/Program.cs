﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Определяем координаты по четверти
string QuterBorderAsk(int numQut)
{
    if (numQut == 1) return "x > 0 : y > 0";
    if (numQut == 2) return "x < 0 : y > 0";
    if (numQut == 3) return "x < 0 : y < 0";
    if (numQut == 4) return "x > 0 : y < 0";

    return String.Empty;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


int num = ReadData("Введите номер четверти: ");
string res = QuterBorderAsk(num);
PrintResult("Четверти № " + res);
