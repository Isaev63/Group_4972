// Задача №20
// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Определяем длинну
double Culc2DDist(int x1, int x2, int y1, int y2)
{
    double res = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)); // 3d (z1 - z2)

    return res;
}

// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


int x1 = ReadData("Введите координату x1: ");
int x2 = ReadData("Введите координату x2: ");
int y1 = ReadData("Введите координату y1: ");
int y2 = ReadData("Введите координату y2: ");
double result = Culc2DDist(x1, x2, y1, y2);
PrintResult("Расстояние " + result);
