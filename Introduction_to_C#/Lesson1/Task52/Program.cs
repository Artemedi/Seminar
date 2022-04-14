//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Возьмем прошлую задачу за основу
Console.WriteLine("Введите количество строк массива: ");
int StrokaMass = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int StolbMass = Convert.ToInt32(Console.ReadLine());
int[,] Mass = new int[StrokaMass, StolbMass];

for (int k = 0; k < StrokaMass; k++)
{
    for (int i = 0; i < StolbMass; i++)
    {
        Mass[k, i] = new Random().Next(0, 10);
        Console.Write($" {Mass[k, i]}\t");
    }
    Console.WriteLine(" ");
}


int sum = 0;
foreach (int v in Mass)
{
    sum += v;
}
Console.Write("Сумма элементов в каждом столбце: ");
Console.Write(sum);
Console.WriteLine(" ");
Console.Write("Среднее арифметическое массива: ");
Console.Write(sum / StolbMass);


