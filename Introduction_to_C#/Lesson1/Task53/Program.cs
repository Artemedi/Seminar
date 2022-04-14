// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int a = 5;
int b = 5;

int [,] array = new int [a,b];

void PrintArray(int[,] localArray){
    for (int i = 0; i <a ; i++)
{
    for (int j = 0; j < b; j++)
    {
        Console.Write($"{array[i,j],4} ");
    }
    Console.WriteLine();
}

}

for (int i = 0; i <a ; i++)
{
    for (int j = 0; j < b; j++)
    {
        array[i,j] = new Random().Next(-5,6);
    }
}
PrintArray(array);
int temp = 0;
    for (int j = 0; j < b; j++)
    {
        temp = array[0,j];
        array[0,j] = array[a-1,j];
        array[a-1,j] = temp;
    }
    Console.WriteLine();
PrintArray(array);
