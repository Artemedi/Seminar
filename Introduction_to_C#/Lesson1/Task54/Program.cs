//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива(в пределах всего массива).


void GenArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            array[k, i] = new Random().Next(0, 10);
            Console.Write($" {array[k, i]}\t");
        }
        Console.WriteLine(" ");
    }
}



Console.WriteLine("Введите количество строк массива: ");
int LineMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int ColumnMass = Convert.ToInt32(Console.ReadLine());
int[,] Mass = new int[LineMass, ColumnMass];
GenArray(Mass);
