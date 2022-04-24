// Задача 62: Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру).

// Объявляем переменные по массиву

int[,] Spiral(int a, int b)
{
    int[,] SpiralArray = new int[a, b]; // Создаю массив
    int counter = 1; // Объявляю начало отсчёта
    int SCol = 0; // Стартовая колонка длины
    int ECol = a - 1; // Конечная колонка длины с минусо от индекса
    int SRow = 0; // Начало высоты строки
    int ERow = b - 1; //Конец высоты строки с минусом от индекса

    while (SCol <= ECol && SRow <= ERow)
    {
        for (int i = SCol; i <= ECol; i++)
        {
            SpiralArray[SRow, i] = counter;
            counter++;
        }
        SRow++;

        for (int i = SRow; i <= ERow; i++)
        {
            SpiralArray[i, ECol] = counter;
            counter++;
        }
        ECol--;

        for (int i = ECol; i >= SCol; i--)
        {
            SpiralArray[ERow, i] = counter;
            counter++;
        }
        ERow--;

        for (int i = ERow; i >= SRow; i--)
        {
            SpiralArray[i, SCol] = counter;
            counter++;
        }
        SCol++;
    }

    return SpiralArray;
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

Console.WriteLine("Введите количество столбцов массива:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк массива:");
int b = Convert.ToInt32(Console.ReadLine());

int[,] ResultArray = Spiral(a,b);
PrintArray(ResultArray);
