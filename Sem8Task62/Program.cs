// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Создаем спиральный массив
int[,] GenerateSpiralArray(int n)
{
    int[,] spiral = new int[n, n];
    int num = 1;
    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = n - 1;

    while (num <= n * n)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            spiral[rowStart, i] = num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            spiral[i, colEnd] = num++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            spiral[rowEnd, i] = num++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            spiral[i, colStart] = num++;
        }
        colStart++;
    }

    return spiral;
}

// Распечатать массив
void Print2DArray(int[,] matrix)
{
    int n = matrix.GetLength(0);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

int[,] spiralArray = GenerateSpiralArray(4);
Print2DArray(spiralArray);
