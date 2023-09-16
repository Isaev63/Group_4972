// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// (задание со *) Сделать оценку времени алгоритма через вещественные числа и строки

// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Возводим в степень
int digitSum(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите число: ");
int result = digitSum(num);
PrintResult($"Сумма цифр {num} => {result}");
