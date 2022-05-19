// Дано число, проверить кратно ли оно 7 или 23

int Digit = new Random().Next(10,1000);
Console.WriteLine(Digit);
int[] Massive = {7,23};
foreach(int number in Massive)
{
    if ((Digit % number) == 0)
{
        Console.WriteLine($"Число {Digit} кратно {number}");
}
    else
{
        Console.WriteLine($"Число {Digit} не кратно {number}");
}
}