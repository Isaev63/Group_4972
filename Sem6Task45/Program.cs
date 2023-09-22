// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.


// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

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

// Создаёт копию заданного массива с помощью поэлементного копирования
int[] CopyArray(int[] array)
{
    int[] copiedArray = new int[array.Length];
    
    // перебор элементов 
    for (int i = 0; i < array.Length; i++)
        copiedArray[i] = array[i];

    return copiedArray;
}

// Печатаем массив
void PrintArray(string msg, int[] arr)
{
    Console.Write(msg);
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int count = ReadData("Введите размер массива: ");

int[] array = GenArray(count, 0, 15);
PrintArray("Оригинальный массив: ", array);

int[] copiedArray = CopyArray(array);
PrintArray("Копия массива: ", copiedArray);
