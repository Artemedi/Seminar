// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Write("Введите число: ");
int Digit = Convert.ToInt32(Console.ReadLine());
Digit = Math.Abs(Digit);
Console.Write(Convert.ToString(Digit).Length);
