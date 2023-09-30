// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Создаем трёхмерный массив
int[,,] Generate3DArray(int sizeX, int sizeY, int sizeZ)
{
    int[,,] array = new int[sizeX, sizeY, sizeZ];
    int number = 10; // Начальное двузначное число

    for (int x = 0; x < sizeX; x++)
    {
        for (int y = 0; y < sizeY; y++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                array[x, y, z] = number++;
            }
        }
    }

    return array;
}

// Печатаем трёхмерный массив
void Print3DArrayWithIndices(int[,,] array)
{
    int sizeX = array.GetLength(0);
    int sizeY = array.GetLength(1);
    int sizeZ = array.GetLength(2);

    for (int x = 0; x < sizeX; x++)
    {
        for (int y = 0; y < sizeY; y++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                Console.WriteLine($"{array[x, y, z]}({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] threeDimensionalArray = Generate3DArray(2, 2, 2);
Print3DArrayWithIndices(threeDimensionalArray);
