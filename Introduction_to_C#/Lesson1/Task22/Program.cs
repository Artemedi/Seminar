// Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("введите число");

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <=N; i++)
{
    Console.WriteLine($"квадрат числа {i} = {i*i}");
}