// Задача 47: Задайте двумерный массив размером m × n,
// заполненный случайными вещественными числами.


// Заполняем двумерный массив
double[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    System.Random rnd = new System.Random();
    double[,] array2D = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(downBorder, topBorder + 1) + rnd.NextDouble();
        }
    }
    return array2D;
}

// Распечатать массив
void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
}

double[,] arr2D = Fill2DArray(5, 5, 0, 100);
Print2DArray(arr2D);
