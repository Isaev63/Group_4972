// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

void Variant1()
{
    // Enter the number
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    // Creating an array of numbers to access them by index
    char[] numArray = num.ToString().ToCharArray();

    // Condition for checking whether the number is three-digit
    if (num >= 100)
    {
        Console.WriteLine("Трьтья цифра числа: " + numArray[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет!");
    }
}

// * Сделать вариант для числа длиной до 10 цифр не используя char или string
void Variant2()
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num >= 100)
    {
        Console.WriteLine("Ошибка: ввод не более двухзначного числа!");
    }
    else if (num >= 10)
    {
        int secondDigit = num % 10;  // We get the second digit of the number
        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    }
    else
    {
        Console.WriteLine("Второй цифры нет!");
    }
}

Variant1();
Variant2();