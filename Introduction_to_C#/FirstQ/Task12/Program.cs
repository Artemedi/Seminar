//12 Удалить вторую цифру трёхзначного числа

int a = new Random().Next(100,1000);
Console.WriteLine(a);
int first = a / 100;
int last = a % 10;
Console.WriteLine($"{first}, {last}");