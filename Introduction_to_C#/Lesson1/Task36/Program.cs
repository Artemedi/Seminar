// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите желаемое количество элементов массива: ");
int[] array = new int[Math.Abs(Convert.ToInt32(Console.ReadLine()))]; //Задаем длину массива из введеного числа
int perem = array.Length;
int count = 0; 

void gen_new_array()
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10, 99);
    }
}

gen_new_array();