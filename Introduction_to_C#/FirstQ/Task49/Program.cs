//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
//Возьмем прошлую задачу за основу
Console.WriteLine("Введите количество строк массива");
int StrokaMass = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int StolbMass = Convert.ToInt32(Console.ReadLine());
int[,] Mass = new int[StrokaMass, StolbMass];

for (int k = 0; k < StrokaMass; k++)
{
    for (int i = 0; i < StolbMass; i++)
    {
        Mass[k, i] = new Random().Next(0, 10);
        Console.Write($" {Mass[k, i]} {i} {k}\t");
        //Это я делал для себя т.к. мне всё ещё очень слонжо матрицы и прочее в голове сопоставлять с индексами
    }
    Console.WriteLine(" ");
}
Console.WriteLine();

void array(int[,] array)
{
    for (int k = 0; k < StrokaMass; k++)
    {
        for (int i = 0; i < StolbMass; i++)
        {
            if ((i == k) && (k % 2 != 0) && (i % 2 != 0))
            {
                //Console.Write($"{Mass[k, i]}\t");
                Mass[k, i]*=Mass[k, i];
            }
            Console.Write($"{Mass[k, i]}\t");
        }
        Console.WriteLine(" ");
    }
}
array(Mass);
