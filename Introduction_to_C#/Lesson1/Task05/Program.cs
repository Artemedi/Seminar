﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли оно чётным (делится на два без остатка)
Console.WriteLine("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(A % 2 == 0 ? "Четное" : "Не четное");
