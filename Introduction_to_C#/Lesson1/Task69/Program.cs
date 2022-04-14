//Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.

Console.Write("Задайте число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int VozStepen(int m, int n)
{
    if (n < 1)
    {
        return 1;
    }
    else
    {
        return m * VozStepen(m, n - 1);
    }
}

Console.WriteLine($"Число {A} в степени {B} = {VozStepen(A,B)}");