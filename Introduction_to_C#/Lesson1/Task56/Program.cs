// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.



// if(ArrayLenght0 == ArrayLenght1)
// {
//     throw new Exception("Заданные условия приводят к квадратному массиву");
// }
// Я хотел как-то сделать проверку на прямоугольник, но не сообразил как. Код выше из интернета, но мы его нигде не проходили,а значит не подходит.

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

int Result(int[,] array)
{
    int min = 0;
    int line = 1;
    for (int j = 0; j < array.GetLength(1); j++)
        {
            min += array[0, j];
            //Console.Write($"{min} ");
        }
    Console.WriteLine($"Сумма строки 1: {min}");
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int min2 = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min2 += array[i, j];
            //Console.Write($"{min2} ");
        }
        if (min2 < min)
        {
            min = min2;
            line= i +1;
        }
        Console.WriteLine($"Сумма строки {i +1}: {min2}");
    }
    return line;
}

Console.WriteLine("Введите количество строк двумерного массива: ");
int ArrayLenght0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива: ");
int ArrayLenght1 = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[ArrayLenght0, ArrayLenght1];
GenArray(Array);
Console.WriteLine($"Сгенерированный массив: ");
PrintArray(Array);
Console.WriteLine($"Строка с наименьшей суммой: {Result(Array)}");