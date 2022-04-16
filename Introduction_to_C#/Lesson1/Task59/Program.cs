//Задача 59: Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
int point0 = 0;
int point1 = 0;

int InputExamNumber() // ввод и проверка числа
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
            //break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int FindMinArray(int[,] matr)
{
    // int point0 = 0;
    // int point1 = 0;
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (min > matr[i, j])
            {
                min = matr[i, j];
                point0 = i;
                point1 = j;
            }
        }
    }
    Console.WriteLine(min);
    return point0;
    //return point1;
}


void DelArray(int[,] mass, int point0, int point1)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if(i != point0 || j != point1)
            {    
               Console.Write($"{mass[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк");
int m = InputExamNumber();
Console.WriteLine("Введите количество столбцов");
int n = InputExamNumber();
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Задан массив");
PrintArray(matrix);
FindMinArray(matrix);
Console.WriteLine($"{point0}, {point1}");
DelArray(matrix, point0, point1);
//PrintArray(matrix);
