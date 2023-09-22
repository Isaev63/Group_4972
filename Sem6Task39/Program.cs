// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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
void printArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] swapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[arr.Length - 1 - i] = arr[i];
    }
    return outArr;
}

void swapArray(int[] arr)
{
    int bufferElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufferElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufferElement;
    }
}

int[] arr = GenArray(15, 1, 100);
printArray(arr);
int[] swapArr = swapNewArray(arr);
Console.WriteLine("Исходный массив:");
printArray(arr);
Console.WriteLine("Перевёрнутый массив #1:");
printArray(swapArr);

swapArray(arr);
Console.WriteLine("Перевёрнутый массив #2:");
printArray(arr);
