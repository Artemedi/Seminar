// Напишите программу, которая на вход принимает три числа и выдаёт самое максимальное.
Console.WriteLine("Введите первое число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int C = Convert.ToInt32(Console.ReadLine());
int MaxValue = A;

if (MaxValue < B) MaxValue = B;
if (MaxValue < C) MaxValue = C;

Console.Write("Максимальное число ");
Console.Write(MaxValue);