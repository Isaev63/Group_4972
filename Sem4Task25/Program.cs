// №25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// (задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень

// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Возводим в степень
double BuildLine(int num, int pow)
{
    double result = 0;
    for (int i = 1; i <= num; i++)
    {
        result = Math.Pow(i, pow);
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
double result = BuildLine(num, pow);
PrintResult($"{num} в степени {pow} => {result}");


// (задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень

class Calculator
{
    static void Main(string[] args)
    {
        // Объявляем переменные для хранения введенных чисел и операции
        double num1, num2;
        char operation;

        // Выводим заголовок программы
        Console.WriteLine("-[ Калькулятор ]-");

        // Запрашиваем у пользователя ввод первого числа
        Console.Write("Введите первое число: ");
        num1 = double.Parse(Console.ReadLine() ?? "0");

        // Запрашиваем у пользователя выбор операции
        Console.Write("Введите операцию (+, -, *, /, ^): ");
        operation = char.Parse(Console.ReadLine() ?? "0");

        // Запрашиваем у пользователя ввод второго числа
        Console.Write("Введите второе число: ");
        num2 = double.Parse(Console.ReadLine() ?? "0");

        // Объявляем переменную для хранения результата
        double result = 0.0;

        // Используем оператор switch для выполнения операций в зависимости от выбора пользователя
        switch (operation)
        {
            case '+':
                // Выполняем сложение
                result = num1 + num2;
                break;
            case '-':
                // Выполняем вычитание
                result = num1 - num2;
                break;
            case '*':
                // Выполняем умножение
                result = num1 * num2;
                break;
            case '/':
                // Проверяем, что делитель не равен нулю, и выполняем деление
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Ошибка: деление на ноль!");
                break;
            case '^':
                // Выполняем возведение в степень
                result = Math.Pow(num1, num2);
                break;
            default:
                // В случае неправильной операции выводим сообщение об ошибке
                Console.WriteLine("Неправильная операция!");
                break;
        }

        // Выводим результат операции на консоль
        Console.WriteLine($"Результат: {result}");
    }
}
