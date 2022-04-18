// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк двумерного массива: ");
int ArrayLenght0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int ArrayLenght1 = Convert.ToInt32(InputExamNumber());


int InputExamNumber() // ввод и проверка числа
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            if (ArrayLenght0 == ArrayLenght1)
            {
                return number;
                break;
            }
            Console.WriteLine("Количество строк и столбцов не должно совпадать.");
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}


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


int[,] Array = new int[ArrayLenght0, ArrayLenght1];
GenArray(Array);
PrintArray(Array);