//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int a = 3;
int b = 3;
int c = 3;

int[,,] array = new int[a,b,c];

void NewArray(int[,,] NewLocArray)
{
    for (int i = 0; i < NewLocArray.GetLength(0); i++)
    {
        for (int k = 0; k < NewLocArray.GetLength(1); k++)
        {
            for (int j = 0; j < NewLocArray.GetLength(2); j++)
            {
                NewLocArray[i,k,j] = i * NewLocArray.GetLength(0) * NewLocArray.GetLength(1) + k * NewLocArray.GetLength(1) + j + 10;
            }
        }
    }
}

void PrintArray(int [,,] PrintLocArray)
{
    for (int i = 0; i < PrintLocArray.GetLength(0); i++)
    {
        for (int k = 0; k < PrintLocArray.GetLength(1); k++)
        {
            for (int j = 0; j < PrintLocArray.GetLength(2); j++)
            {
                Console.Write($"array[{i},{k},{j}] = {PrintLocArray[i,k,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
NewArray(array);
PrintArray(array);