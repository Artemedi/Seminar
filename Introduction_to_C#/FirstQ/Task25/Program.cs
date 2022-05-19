// Напишите цикл, который принимает на вход два числа (A и B) и возводит число B в натуральную степень A.
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
A = Math.Abs(A);
B = Math.Abs(B);
int C = 1;
for(int i = 1; i <= A; i++)
{
   C*= B;
}
Console.WriteLine(C);
Console.WriteLine((Math.Pow(B, A)));