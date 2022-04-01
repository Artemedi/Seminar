// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве

Console.WriteLine("Введите желаемое количество элементов массива");
int perem = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//Получаем из ввода число и путем ABS делаем его всего положительным
int[] array = new int[perem];
//Задаем длину массива из введеного числа
int count = 0;
Console.Write("Исходный массив: ");

for (int i = 0; i < perem; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
Console.Write("Чётные числа в массиве: ");
for (int i = 0; i < perem; i++)
{
    if(array[i] % 2 == 0)
    {
        Console.Write(array[i] + " ");
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {count}");

