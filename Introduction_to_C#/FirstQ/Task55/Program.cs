// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.

int a = 6;
int b = 6;
int[,] array = new int[a, b];

void PrintArray(int[,] localArray)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }
}
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        array[i, j] = new Random().Next(0, 51);
    }
}
if (a != b)
{
    Console.WriteLine("Действие невозможно");
}
else
{
    PrintArray(array);
    int temp = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = i; j < b; j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    Console.WriteLine();
    PrintArray(array);
}
