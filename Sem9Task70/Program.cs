//==========================================
//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возведите А в степень В с помощью рекурсии
//==========================================


// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long RecPow(int a, int b)
{
    long res = 1;
    if (b <= 0) return 1;
    else res = a * RecPow(a, b - 1);
    return res;
}

long MyPow(int a, int b)
{
    if (b == 2) return a * a;
    if (b == 1) return a;
    if (b % 2 == 0) return MyPow(a, b / 2) * MyPow(a, b / 2);
    else return MyPow(a, b / 2) * MyPow(a, b / 2 + 1);
}

int numA = ReadData("Введите число: ");
int numB = ReadData("Введите число: ");
Console.WriteLine(RecPow(numA, numB));
Console.WriteLine(MyPow(numA, numB));
