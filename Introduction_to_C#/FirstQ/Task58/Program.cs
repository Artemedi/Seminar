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

int[,] MatrixC(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] = arrayC[i, j] + arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
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
int[,] ResultMatrixC = MatrixC(ArrayOne, ArrayTwo);
Console.WriteLine($"Произведение двух матриц:");
PrintArray(ResultMatrixC);

// if (ArrayOne.GetLength(1) != ArrayTwo.GetLength(0))
//     {
//         Console.WriteLine("Матрицы невозможно перемножить в таком порядке!");
//     }
// else
// {
//     Console.WriteLine("Матрицы возможно перемножить в таком порядке!");
// }
// Я не смог понять как бы мне сделать проверку на множитель. Точнее я понимаю, что можно через if, но я не знаю как остановить выполнение программы.
// Пробовал делать и в методе и просто if и в проверке на ввод. Сообразить не могу как сделать правильно. Плюс массивы.
// В итоге я просто всё жестко ограничил и сделал, что бы вторая матрица просто использовала теже параметры, что и первая.
// Более того, я подсмотрел решение по вычислению матрицы т.к. уже говорил ранее - я полный профан в математике и даже такая база мне даётся с трудом.