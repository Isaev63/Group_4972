// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Возводим в любую степень
string BuildLine(int num, int pow)
{
    string result = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        result = result + Math.Pow(i, pow) + " | ";
    }
    return result;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите число: ");
int pow = ReadData("Введите степень: ");
string result = BuildLine(num, pow);
PrintResult("Расстояние " + result);


// * Вывести таблицу с границами и значениями друг над другом

using System;

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Возводим в любую степень и формируем строку для таблицы
string BuildLine(int num, int pow)
{
    string line = "+----------+------------+\n";
    line += "|   Число  | Возведено в " + pow + " |\n";
    line += "+----------+------------+\n";

    for (int i = 1; i <= num; i++)
    {
        line += "|   " + i.ToString().PadRight(4) + "   |   " + Math.Pow(i, pow).ToString().PadRight(9) + "   |\n";
    }

    line += "+----------+------------+";

    return line;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите число: ");
int pow = ReadData("Введите степень: ");
string result = BuildLine(num, pow);
PrintResult(result);
