// №43 Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
// (*) Найдите площадь треугольника образованного пересечением 3 прямых


void CrossPoint()
{
    try
    {
        Console.Write("Введите k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine() ?? "0");
        Console.Write("Введите b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine() ?? "0");
        Console.Write("Введите k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine() ?? "0");
        Console.Write("Введите b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine() ?? "0");

        // Находим точки пересечения
        double x = (b2 - b1) / (k2 - k1);
        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

        if (k1 == k2)
        {
            Console.Write("Заданные прямые не пересекаются!");
        }
        else
        {
            Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
        }
    }
    catch (FormatException)
    {
        // Выводим ошибку, если пользователь ввёл не число
        Console.WriteLine($"Ошибка ввода: Вводите только число!");
    }
}

CrossPoint();


// (*) Найдите площадь треугольника образованного пересечением 3 прямых
void FindTriangleArea()
{
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine() ?? "0");
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine() ?? "0");
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine() ?? "0");
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine() ?? "0");
    Console.Write("Введите k3: ");
    double k3 = Convert.ToDouble(Console.ReadLine() ?? "0");
    Console.Write("Введите b3: ");
    double b3 = Convert.ToDouble(Console.ReadLine() ?? "0");

    if (k1 == k2 && k2 == k3)
    {
        Console.WriteLine("Заданные прямые совпадают, треугольник не существует.");
    }
    else
    {
        // Находим точку пересечения всех трех прямых
        double delta = k1 * k2 * k3 - k1 * k2 - k2 * k3 - k3 * k1;
        if (delta != 0)
        {
            double x = (b1 * b2 * k3 - b1 * b2 - b2 * b3 - b3 * b1) / delta;
            double y = (k1 * b2 * b3 - k1 * b2 * b1 - k2 * b3 * b2 - k3 * b1 * b3) / delta;

            // Рассчитываем длины сторон треугольника
            double AB = Math.Sqrt(Math.Pow(x - b1, 2) + Math.Pow(y - k1, 2));
            double BC = Math.Sqrt(Math.Pow(x - b2, 2) + Math.Pow(y - k2, 2));
            double CA = Math.Sqrt(Math.Pow(x - b3, 2) + Math.Pow(y - k3, 2));

            // Рассчитываем площадь треугольника с помощью формулы Герона
            double s = (AB + BC + CA) / 2;
            double triangleArea = Math.Sqrt(s * (s - AB) * (s - BC) * (s - CA));

            Console.WriteLine($"Точка пересечения заданных прямых: ({x}; {y})");
            Console.WriteLine($"Площадь треугольника: {triangleArea}");
        }
        else
        {
            Console.WriteLine("Прямые параллельны, треугольник не существует.");
        }
    }
}

FindTriangleArea();
