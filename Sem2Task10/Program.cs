// №10 Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// number generator from 100 to 1000
int num = new Random().Next(100, 1000);
Console.WriteLine(num);

// Creating an array of numbers to access them by index
char[] digitChar = num.ToString().ToCharArray();

// Take the second number from the array
Console.WriteLine("Вторая цифра числа " + digitChar[1]);
