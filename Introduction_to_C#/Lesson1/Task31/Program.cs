// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] mass = new int[12];
int len = mass.Length;
int index = 0;
int ResNegative = 0;
int ResPositive = 0;

void MassiveStart(int[] array)
{
    while(index < len)
    {
        array[index] = new Random().Next(-9, 10);
        index++;
    }
    for(int i = 0; i < len; i++)
    {
        if(array[i] > 0)
        {
            ResPositive += array[i];
        }
        else
        {
            ResNegative += array[i];
        }
    Console.WriteLine(mass[i]);
    }
}

MassiveStart(mass);
Console.WriteLine("");
Console.WriteLine($"Сумма негативных {ResNegative}, сумма позитивных {ResPositive}");