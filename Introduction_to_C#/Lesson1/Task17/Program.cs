// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("input x");

int x = int.Parse(Console.ReadLine());
Console.WriteLine("input y");
int y = int.Parse(Console.ReadLine());

if (x > 0 & y > 0)
{
Console.WriteLine("first quarter");
}
else if (x < 0 & y > 0 )
{
Console.WriteLine("second quarter");
}
else if (x<0 & y<0)
{
Console.WriteLine("third quarter");
}
else if (x>0 & y <0)
{
Console.WriteLine("fourth quarter");
}
else 
{
Console.WriteLine("can't define quarter");
}