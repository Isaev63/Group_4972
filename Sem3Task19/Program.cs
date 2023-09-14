// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Определяем, является ли число полиндромом
bool IsPalindrome(int number)
{
    // Проверяем, явдяется ли число пятизначным
    if (number > 99999 || number < 10000)
    {
        Console.WriteLine("Число не пятизначное!");
        return false;
    }

    // Разбиваем число на цифры
    int digit_5 = number % 10;
    int digit_4 = (number / 10) % 10;
    int digit_2 = (number / 1000) % 10;
    int digit_1 = (number / 10000) % 10;

    // Проверяем, является ли число полиндромом
    if (digit_1 == digit_5 && digit_2 == digit_4)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


int num = ReadData("Введите число: ");
bool res = IsPalindrome(num);
PrintResult("Число полиндром: " + res);
