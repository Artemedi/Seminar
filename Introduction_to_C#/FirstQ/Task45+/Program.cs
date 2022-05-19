// Задача 45+: В матрице чисел найти сумму элементов главной диагонали.

Console.WriteLine("Введите количество строк массива");
int StrokaMass = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int StolbMass = Convert.ToInt32(Console.ReadLine());
int[,] Mass = new int[StrokaMass, StolbMass];

for (int k = 0; k < StrokaMass; k++)
{
    for (int i = 0; i < StolbMass; i++)
    {
        Mass[k, i] = new Random().Next(0, 9);
        Console.Write($" {Mass[k, i]}\t");
    }
    Console.WriteLine(" ");
}
int Sum = 0;
for (int k = 0; k < StrokaMass; k++)
{
    for (int i = 0; i < StolbMass; i++)
    {
        if (i == k)
            Sum += Mass[k, i];
    }

}
Console.WriteLine($"Сумма чисел диагонали массива = {Sum}");