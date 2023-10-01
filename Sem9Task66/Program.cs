// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Рекурсивное нахождение суммы чисел от M до N
int SumRecMN(int m, int n)
{
    int res = 0;

    if (n <= m) { res = n; }
    else { res = m + SumRecMN(m + 1, n); }

    return res;
}

int numM = ReadData("Введите число: ");
int numN = ReadData("Введите число: ");
Console.WriteLine($"Сумма чисел от {numM} до {numN} ровна: {SumRecMN(numM, numN)}");
