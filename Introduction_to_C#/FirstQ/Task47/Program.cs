// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива: ");
int LineArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int ColumnArray = Convert.ToInt32(Console.ReadLine());

double[,] Array = new double[LineArray, ColumnArray];
Random rnd = new Random();  //Здесь генерируем случайные числа

for (int k = 0; k < LineArray; k++)
{
    for (int i = 0; i < ColumnArray; i++)
    {
        Array[k, i] = rnd.NextDouble() * (10 - -10) + -10; 
        // Сама функция возвращает от 0.0 до 1.0, согласно документации. 
        // И потому предлагается формула из документации https://docs.microsoft.com/ru-ru/dotnet/api/system.random?view=net-6.0
        // Random.NextDouble() * (maxValue - minValue) + minValue  
        // Точно сойду с ума.
        Console.Write($" {Array[k, i]}\t"); // \t я так понимаю перенос строки. Что-то новое.
    }
    Console.WriteLine(" ");
}