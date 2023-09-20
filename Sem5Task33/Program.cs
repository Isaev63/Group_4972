// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


//Заполняем одномерный массив
int[] GenArray(int length, int lowBorder, int highBorder)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }

    return array;
}

// Печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Выявляем необходимый элемент в массиве
string FindElement(int[] arr, int elm)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elm)
        {
            return $"Индекс искомого числа: {i}";
        }
    }

    return "Такого числа нет!";
}

int[] array = GenArray(12, -9, 9);
PrintArray(array);
int countElement = ReadData("Введите искомое число: ");
Console.WriteLine(FindElement(array, countElement));
