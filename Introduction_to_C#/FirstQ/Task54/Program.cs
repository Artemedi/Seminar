//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива(в пределах всего массива).

void GenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, min])
                {
                    min = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = array[i, min];
            array[i, min] = temp;
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк двумерного массива: ");
int ArrayLenght0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int ArrayLenght1 = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[ArrayLenght0, ArrayLenght1];

GenArray(Array);
Console.WriteLine("Сгенерированный массив:");
PrintArray(Array);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintArray(SortArray(Array));