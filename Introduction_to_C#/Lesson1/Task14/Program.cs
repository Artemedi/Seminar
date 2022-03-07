// Найти третью цифру числа или сообщить, что её нет

int Number = 0;
Console.WriteLine("Get number ");
Number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (Number >= 100 | Number < 99) 
{
    Number /= 100;
    int ThirdDigit = Number % 10;
    Console.WriteLine("Number of third Digit  is " + ThirdDigit);
} 
else 
{
    Console.WriteLine("Number does't have third digit");
}