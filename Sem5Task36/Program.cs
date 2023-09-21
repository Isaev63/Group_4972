// №36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// (*) Найдите все пары в массиве и выведите пользователю


//Заполняем одномерный массив
int[] genArray(int length, int lowBorder, int highBorder)
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

// Находим сумму элементов, стоящих на нечётных позициях
int sumOddPosition(int[] arr)
{
    int oddSum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        oddSum += arr[i];
    }
    return oddSum;
}

int[] array = genArray(12, -9, 9);
printArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOddPosition(array)}");


// (*) Найдите все пары в массиве и выведите пользователю

//Заполняем одномерный массив
int[] genArray(int length, int lowBorder, int highBorder)
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

// Находим все пары в массиве
void findPairs(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                Console.WriteLine($"Пара: [{arr[i]}, {arr[j]}]  ->  Индекс: [{i}, {j}]");
            }
        }
    }
}

int[] array = genArray(15, 0, 99);
printArray(array);
findPairs(array);
