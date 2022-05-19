// Напишите программу, которая на вход принимает два числа и выдаёт какое больше, а какое меньше.
Console.WriteLine("Введите первое число:");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > SecondNumber)
{
  Console.Write("Число ");
  Console.Write(FirstNumber);
  Console.Write(" большее. ");
  Console.Write("Число ");
  Console.Write(SecondNumber);
  Console.Write(" меньшее.");
}
else if (FirstNumber == SecondNumber)
{
  Console.Write("Число ");
  Console.Write(SecondNumber);
  Console.Write(" и ");
  Console.Write(FirstNumber);
  Console.Write(" равны.");
}
else
{
  Console.Write("Число ");
  Console.Write(SecondNumber);
  Console.Write(" большее. ");
  Console.Write("Число ");
  Console.Write(FirstNumber);
  Console.Write(" меньшее.");
}
