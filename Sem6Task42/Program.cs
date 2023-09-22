// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Из десятичной в двоичную
string DecToBin(int num)
{
    string line = "";
    while (num > 0)
    {
        line = num % 2 + line;
        num /= 2;
    }
    return line;
}

int number = ReadData("Введите число: ");
Console.WriteLine(DecToBin(number));
