// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintFibNum(int num)
{
    int buf = 0;
    int first = 0;
    int second = 1;
    Console.Write($"{first} {second}");
    for (int i = 2; i < num; i++)
    {
        Console.Write(" " + (first + second));
        buf = first + second;
        first = second;
        second = buf;
    }
}

int number = ReadData("Введите чесло: ");
PrintFibNum(number);
