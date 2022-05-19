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


// double sum = 0;
// foreach (int v in Mass)
// {
//     sum += v;
// }
// Перечитал условие. Некорректно. Нужно ведь каждого столбца
double sum = 0;
for (int i = 0; i < Mass.GetLength(0); i++)
{
    for (int k = 0; k < Mass.GetLength(1); k++)
    {
        sum += Mass[i, k];
    }
    Console.WriteLine($"Сумма элементов в столбце: {sum} и его среднее арефметическое значение: {sum / Mass.GetLength(0)}");
}

//Хотя сейчас смотрю и понимаю, что так же можно было через foreach, наверное и через void




