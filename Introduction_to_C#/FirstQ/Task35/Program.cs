// Задача 35.Задайте массив из 123 случайных чисел. Найдите количество элементов из отрезка [10,99].

int perem = 123;
int[] mass = new int[perem];
int index = 0;
int count = 0;

void MassiveStart(int[] array)
{
    while(index < perem)
    {
        array[index] = new Random().Next(0, 999);
        index++;
    }
    for (int i = 0; i < perem; i++)
    {
        if(mass[i] >= 10 && mass[i] <= 99)
            {
                count++;
                Console.Write($"{mass[i]} ");
            }
    }
Console.WriteLine("");
}

MassiveStart(mass);
Console.WriteLine($"Количество элементов из отрезка равняется {count}");
