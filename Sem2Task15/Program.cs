// №15 Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

void Variant1()
{
    Console.Write("Введите число дня недели (1-7): ");
    int numDay = int.Parse(Console.ReadLine() ?? "0");

    // Creating a verification condition
    if (numDay > 7)     // If the input is greater than 7
    {
        Console.WriteLine("Ошибка: дней не может быть больше 7!");
    }
    else if (numDay >= 1 && numDay <= 5)    // If the input is in the range from 1 to 5
    {
        Console.WriteLine("Рабочий день");
    }
    else    // If the input is in the range from 6 to 7
    {
        Console.WriteLine("Выходной день!");
    }
}

// * Сделать вариант с использованием конструкции Dictionary
void Variant2()
{
    // Creating a dictionary
    Dictionary<int, string> weekDays = new Dictionary<int, string>
    {
        {1, "Понедельник"},
        {2, "Вторник"},
        {3, "Среда"},
        {4, "Четверг"},
        {5, "Пятница"},
        {6, "Суббота"},
        {7, "Воскресенье"}
    };

    Console.Write("Введите число дня недели (1-7): ");
    int numDay = int.Parse(Console.ReadLine() ?? "0");

    // We check the correctness of entering a number from 1 to 7
    if (numDay >= 1 && numDay <= 7)
    {
        string dayName = weekDays[numDay];  // We get the day of the week from the dictionary by the "key"

        // Checking the day of the week
        if (numDay >= 1 && numDay <= 5)
        {
            Console.WriteLine($"{dayName} - Рабочий день");
        }
        else
        {
            Console.WriteLine($"{dayName} - Выходной день!");
        }
    }
    else    // If the input is greater than 7
    {
        Console.WriteLine("Ошибка: дней не может быть больше 7!");
    }
}

Variant1();
Variant2();
