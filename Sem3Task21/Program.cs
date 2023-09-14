// №21 Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек

// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Определяем растоянние между двумя точками в 3D пространстве
double Length(int[] pointA, int[] pointB)
{
    double DistanceBetweenPoints(int x1, int x2, int x3, int y1, int y2, int y3)
    {
        double distance = Math.Sqrt((x1 - y1) * (x1 - y1) + (x2 - y2) * (x2 - y2) + (x3 - y3) * (x3 - y3));
        return distance;
    }
    return DistanceBetweenPoints(pointA[0], pointA[1], pointA[2], pointB[0], pointB[1], pointB[2]);
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x1 = ReadData("Введите x1: ");
int x2 = ReadData("Введите x2: ");
int x3 = ReadData("Введите x3: ");
int y1 = ReadData("Введите y1: ");
int y2 = ReadData("Введите y2: ");
int y3 = ReadData("Введите y3: ");
double res = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
PrintResult($"Растояние между точками: {res:F2}");


// * Сделать метод загрузки точек

// Метод для ввода координат точек
int[] ReadPoint(string pointName)
{
    Console.Write("Введите x: ");
    int x = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите y: ");
    int y = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите z: ");
    int z = int.Parse(Console.ReadLine() ?? "0");
    return new int[] { x, y, z };
}

// Определяем растоянние между двумя точками в 3D пространстве
double Length(int[] pointA, int[] pointB)
{
    double DistanceBetweenPoints(int x1, int x2, int x3, int y1, int y2, int y3)
    {
        double distance = Math.Sqrt((x1 - y1) * (x1 - y1) + (x2 - y2) * (x2 - y2) + (x3 - y3) * (x3 - y3));
        return distance;
    }
    return DistanceBetweenPoints(pointA[0], pointA[1], pointA[2], pointB[0], pointB[1], pointB[2]);
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] pointA = ReadPoint("A");
int[] pointB = ReadPoint("B");
double res = Length(pointA, pointB);
PrintResult($"Растояние между точками: {res:F2}");
