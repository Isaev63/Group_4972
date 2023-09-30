// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Заполняем двумерный массив
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder);
        }
    }
    return array2D;
}

// Распечатать двумерный массив
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Находим строку с наименьшей суммой элементов
int FindSmallestSumLine(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minSumRowIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int elementSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            elementSum += matrix[i, j];
        }

        // Проверяем, является ли текущая сумма элементов строки меньшей, чем minSum
        if (elementSum < minSum)
        {
            minSum = elementSum; // Если да, обновляем minSum
            minSumRowIndex = i + 1; // и minSumRowIndex
        }
    }
    // Возвращаем индекс строки с наименьшей суммой элементов
    return minSumRowIndex;
}

int[,] arr2D = Fill2DArray(4, 4, 0, 10);
Print2DArray(arr2D);
Console.WriteLine($"Строка с наименьшей суммой элементов: {FindSmallestSumLine(arr2D)}");
