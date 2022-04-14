//Задача 45: Напишите программу, которая будет создавать копию заданного массива 
//с помощью поэлементного копирования (программа копирования массива)

Console.WriteLine("Введите длинну массива");
int LenghtMass = Convert.ToInt32(Console.ReadLine());
int[] Mass = new int[LenghtMass];
int[] MassCopy; // = new int[LenghtMass];

for (int k = 0; k < Mass.Length; k++)
{
    Mass[k] = new Random().Next(-100, 101);
    Console.Write($" {Mass[k]}");
}

Console.WriteLine(" ");

int[] Copy(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

MassCopy = Copy(Mass);

for (int j = 0; j < MassCopy.Length; j++)
{
    Console.Write($" {MassCopy[j]}");
}