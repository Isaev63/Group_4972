// ---------------------------------------------------------------------
//                                 Задача 65
// Задайте значения M и N. Напишите программу, 
// которая найдёт все натуральные элементы в промежутке от M до N.
// ---------------------------------------------------------------------


// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string RecMN(int m, int n)
{
    string res = String.Empty;

    if (n <= m) { res = n.ToString(); }
    else { res = $"{m} {RecMN(m + 1, n)}"; }

    return res;
}

int numN = ReadData("Введите число: ");
int numM = ReadData("Введите число: ");
Console.WriteLine(RecMN(numN, numM));
