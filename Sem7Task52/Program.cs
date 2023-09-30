// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.


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

// Распечатать двумерный массив
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

// Находим среднее арифметическое каждого столбца матрицы
double[] FindAverageInColumns(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    double[] averages = new double[cols];

    for (int j = 0; j < cols; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, j];
        }
        averages[j] = sum / rows;
    }

    return averages;
}

// Печатаем результат нахождения
void PrintListAvr(double[] averages)
{
    Console.WriteLine("The averages in columns are: ");
    foreach (double avg in averages)
    {
        Console.Write($"{avg:f2}\t");
    }
    Console.WriteLine();
}

int[,] arr2D = Fill2DArray(4, 4, 2);
Print2DArray(arr2D);
PrintListAvr(FindAverageInColumns(arr2D));
