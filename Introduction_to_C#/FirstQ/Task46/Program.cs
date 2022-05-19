// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами

Console.WriteLine("Введите количество строк массива");
int StrokaMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int StolbMass = Convert.ToInt32(Console.ReadLine());
int[,] Mass = new int[StrokaMass, StolbMass];

for (int k = 0; k < StrokaMass; k++)
{
    for (int i = 0; i < StolbMass; i++)
    {
        Mass[k, i] = new Random().Next(-10, 11);
        Console.Write($" {Mass[k, i]}\t");
    }
    Console.WriteLine(" ");
}