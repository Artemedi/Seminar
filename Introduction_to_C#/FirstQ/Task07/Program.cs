// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные чила от 1 до N.
Console.WriteLine( "Get number N" );
int N = Convert.ToInt32(Console.ReadLine());
int N1 = 1; 

while (N1 <= N)
{
    if (N1 % 2 == 0)
    {
        Console.Write(N1 + " ");
        N1 += 1;
    }
    else 
    {
        N1 += 1;
    }
}