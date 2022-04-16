// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита. 
//Пример: n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс

Console.WriteLine("Введите желаемую длину символов: ");
int N = Convert.ToInt32(Console.ReadLine());
int C = 1;
string Alpha = "аисв";

void ToWord(string StrAlpha, char[] LocAlpha, int n = 0)
{
    if (n == LocAlpha.Length)
    {
        Console.WriteLine($"{C++} {new String(LocAlpha)}");
    }
    else
    {
        for (int i = 0; i < StrAlpha.Length; i++)
        {
            LocAlpha[n] = StrAlpha[i];
            ToWord(StrAlpha, LocAlpha, n + 1);
        }
    }
}
ToWord(Alpha, new char[N]);