// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

// Распечатать массив
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

// Соритруем строки массива
void SortRowsDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Создаем временный массив для сортировки строки
        int[] row = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            row[j] = matrix[i, j];
        }

        // Сортируем временный массив по убыванию
        Array.Sort(row, (a, b) => -a.CompareTo(b));

        // Заменяем исходную строку отсортированным массивом
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = row[j];
        }
    }
}

int[,] arr2D = Fill2DArray(4, 4, 0, 10);
Print2DArray(arr2D);
Console.WriteLine();
SortRowsDescending(arr2D);
Print2DArray(arr2D);
