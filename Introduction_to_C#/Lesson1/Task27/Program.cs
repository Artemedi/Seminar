// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine());
int res = 0;
int b = 0;
while (a > 0)
{
    b = a % 10;
    res += b;
    a = a / 10;
}
Console.WriteLine($"Сумма цифр в числе будет равна {res}");