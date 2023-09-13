// Задача №22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Определяем квадрат чисел
string BuildLine(int num, int pow)
{
    string result = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        result = result + Math.Pow(i, pow) + ", ";
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
