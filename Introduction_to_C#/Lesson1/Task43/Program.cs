//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем или задаются вручную.

Console.WriteLine("Введите два координата первых точек");

int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите два координата вторых точек");

int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());

// y = k1 * x + b1, 
// y = k2 * x + b2;

int x = (b2 - b1)/(k1 - k2);
int y = k1 * (b2 - b1) / (k1 - k2) + b1;

Console.WriteLine($"Координаты точки Х: {x}");
Console.WriteLine($"Координаты точки Y: {y}");
