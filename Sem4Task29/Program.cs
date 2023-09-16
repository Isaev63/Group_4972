// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов

// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Генерируем массив
int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int num = ReadData("Введите длинну массива: ");
int[] res = GenArr(num);
PrintArray(res);


// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов

// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Генерируем массив
int[] GenArr(int len, int minVal, int maxVal)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(minVal, maxVal + 1);
    }
    return arr;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int len = ReadData("Введите длинну массива: ");
int minV = ReadData("Введите минимальный диапазон массива: ");
int maxV = ReadData("Введите максимальный диапазон массива: ");
int[] res = GenArr(len, minV, maxV);
PrintArray(res);
