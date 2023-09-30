// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


// Заполняем двумерный массив
int[,] Fill2DArray(int n, int m, int k)
{
    int[,] array2D = new int[n, m];
    int value = 1;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array2D[i, j] = value;
            value += k;
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
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    int rowCount = matrix.GetLength(0);
    int columnCount = matrix.GetLength(1);

    if (rowPosition >= 1 && rowPosition <= rowCount && columnPosition >= 1 && columnPosition <= columnCount)
    {
        int value = matrix[rowPosition - 1, columnPosition - 1];
        return new int[] { value, 0 }; // Возвращаем значение и 0, чтобы показать успешное выполнение
    }
    else
    {
        // Возвращаем два нуля, чтобы показать, что координаты за пределами границ массива
        return new int[] { 0, 0 };
    }
}

void PrintCheckIfError(int[] result, int x, int y)
{
    if (result[0] == 0 && result[1] == 0)
    {
        Console.WriteLine("There is no such index");
    }
    else
    {
        Console.WriteLine($"The number in [{x}, {y}] is {result[0]}");
    }
}

int[,] arr2D = Fill2DArray(3, 4, 2);
Print2DArray(arr2D);

int[] result = FindNumberByPosition(arr2D, 2, 2);
PrintCheckIfError(result, 2, 2);
