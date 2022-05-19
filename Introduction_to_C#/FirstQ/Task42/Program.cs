//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.WriteLine("Введите число для конвертации: ");
int a = Convert.ToInt32(Console.ReadLine());

void ToBin(int n)
{
    if(n==0)
    {
        return;
    }
    
    ToBin(n/2);
    Console.Write(n%2);
}
Console.Write($"Конвертация числа {a} через функцию: ");
ToBin(a);
Console.WriteLine();
int number = a;
Console.Write($"Конвертация числа {number} через цикл: ");
int d10 = 1;
int result = 0;
while (number != 0)
{
    result = result + number % 2 * d10;
    number= number /2;
    d10 = d10 * 10;
}
System.Console.WriteLine(result);
