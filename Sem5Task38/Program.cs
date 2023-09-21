// №38 Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// (*) Отсортируйте массив методом вставки и методом подсчета, 
// а затем найдите разницу между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.


//Заполняем одномерный массив
double[] genArray(int length, double lowBorder, double highBorder)
{
    double[] array = new double[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * (highBorder - lowBorder) + lowBorder;
    }

    return array;
}

// Печатаем массив
void printArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]:F2}" + ", ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]:F2}" + "]");
}

// Находим разницу между максимальным и минимальным элементом массива
double differenceNumber(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }

    result = max - min;
    return result;
}

double[] array = genArray(12, 0, 99);
printArray(array);
Console.WriteLine($"Разница элементов: {differenceNumber(array):F2}");
