// Вводим данные
int ReadData(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void GenLineRec(int num)
{
    Console.Write(num + " ");
    if (num <= 1) { }
    else { GenLineRec(num - 1); }
}

int num = ReadData("Введите число: ");
GenLineRec(num);