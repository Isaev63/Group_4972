// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Рекурсивный вывод чисел от N до 1
void GenLineRec(int num)
{
    Console.Write(num + " ");
    if (num <= 1) { }
    else { GenLineRec(num - 1); }
}

int num = ReadData("Введите число: ");
GenLineRec(num);
