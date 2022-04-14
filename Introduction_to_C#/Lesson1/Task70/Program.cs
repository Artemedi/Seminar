// Задача 70: Напишите программу, которая на вход принимает два числа и 
//выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.


//3 и 4, N = 5 -> 3 4 7 11 18 6 и 10, N = 4 -> 6 10 16 26 

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N число: ");
int N = Convert.ToInt32(Console.ReadLine());

void FuncRec(int q, int d, int s)
{
    if(s < 4)
    {
        Console.Write($"{q + d} ");
    }
    else
    {
        Console.Write($"{q + d} ");
        FuncRec(d, q + d, s -1);
    }
}
Console.Write($"{a} {b} ");
FuncRec(a,b,N);
//Console.WriteLine($"");