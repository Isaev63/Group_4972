// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

bool triangleTest(int a, int b, int c)
{
    bool res = true;
    if (a + b < c) res = false;
    if (b + c < a) res = false;
    if (a + c < b) res = false;
    return res;
}

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
int numC = ReadData("Введите число C: ");
Console.WriteLine(triangleTest(numA, numB, numC));
