//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = 1;
for (int i = 1; i <= A; i++)
{
    B *= i;
}
Console.Write($"Сумма произведений числа {A} равняется {B}");