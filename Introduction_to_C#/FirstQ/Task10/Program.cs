// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
int Digit = new Random().Next(100,1000);
Console.WriteLine($"Дано число {Digit}");
int FirstDigit = (Digit % 100) / 10;
Console.WriteLine($"Вторая цифра {FirstDigit}");