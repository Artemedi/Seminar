// Выяснить, кратное ли число заданному, если нет, вывести остаток
Console.WriteLine("Введите первое число");
int Digit1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Digit2 = Convert.ToInt32(Console.ReadLine());
if ((Digit1 % Digit2)==0)
{
    Console.WriteLine("Числа кратные");
}
else
{
    Console.WriteLine($"Числа не кратные, остаток {(Digit1 % Digit2)}");
}