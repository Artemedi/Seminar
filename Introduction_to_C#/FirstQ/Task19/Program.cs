// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int Digit = Convert.ToInt32(Console.ReadLine());
if ((Convert.ToString(Digit).Length) == 5)
{
    if ((Digit % 10)==(Digit / 10000) & (Digit % 100 / 10)==(Digit / 1000 % 10))
    // Беру последний символ Digit % 10 и сравниваю его с первым символом Digit / 10000
    // Беру два последних и усекаю до первого (Digit % 100 / 10) и сравниваю так же со вторым символом (Digit / 1000 % 10))
    {
        Console.WriteLine($"Число {Digit} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {Digit} не является палиндромом");
    }

}
else
{
    if ((Convert.ToString(Digit).Length) < 5)
    {
        Console.WriteLine($"Число {Digit} меньше заданого условия.");
    }
    else
    {
        Console.WriteLine($"Число {Digit} больше заданого условия.");
    }
}