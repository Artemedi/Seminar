// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество элементов ");
int perem = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] mass = new int[perem];
int index = 0;

void MassiveStart(int[] array)
{
    while(index < perem)
    {
        array[index] = new Random().Next(-9, 10);
        Console.Write($" {mass[index]}");
        index++;
    }
    Console.WriteLine("");
    for (int i = 0; i < perem; i++)
    {
        mass[i] *= -1;
        Console.Write($" {mass[i]}");
    }
}
MassiveStart(mass);
