// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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



Console.WriteLine("Введите количество строк двумерного массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] ArrayOne = new int[a, b];
int[,] ArrayTwo = new int[a, b];
GenArray(ArrayOne);
GenArray(ArrayTwo);
Console.WriteLine($"Сгенерированный массив 1: ");
PrintArray(ArrayOne);
Console.WriteLine($"Сгенерированный массив 2: ");
PrintArray(ArrayTwo);

if (ArrayOne.GetLength(1) != ArrayTwo.GetLength(0))
    {
        Console.WriteLine("Матрицы невозможно перемножить в таком порядке!");
    }
else
{
    Console.WriteLine("Матрицы возможно перемножить в таком порядке!");
}