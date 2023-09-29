// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


// Заполняем двумерный массив
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
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

void FindMin(int[,] arr, ref int x, ref int y)
{
    int min = arr[0, 0];
    x = 0;
    y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] CreateArr(int[,] arr, int x, int y)
{
    int k = 0;
    int m = 0;
    int[,] outArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == x) { }
        else
        {
            m = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == y) { }
                else
                {
                    outArr[k, m] = arr[i, j];
                    m++;
                }
            }
            k++;
        }
    }
    return outArr;
}

int[,] arr2D = Fill2DArray(5, 5, 10, 0);
Print2DArray(arr2D);
Console.WriteLine();
int x = -1;
int y = -1;
FindMin(arr2D, ref x, ref y);
int[,] outArr = CreateArr(arr2D, x, y);
Print2DArray(outArr);
