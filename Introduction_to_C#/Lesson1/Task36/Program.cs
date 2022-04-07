// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write("Введите желаемое количество элементов массива: ");
int[] array = new int[Math.Abs(Convert.ToInt32(Console.ReadLine()))]; //Задаем длину массива из введеного числа

void gen_new_array()
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10, 99);
    }
}

int[] find_sum(int[] find_sum_array)
{
    int suma = 0;
    bool zpt = false;
    Console.Write("Элементы стоящие на нечётных позицих: [");
    for (int i = 0; i < array.Length; i++)
    {

        if (i % 2 != 0)
        {
            if (zpt)
            {
                Console.Write(", ");
            }
            Console.Write("{0}", find_sum_array[i]);
            suma = suma + find_sum_array[i];
            zpt = true;
        }
        
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Сумма эллементов стоящих на нечётных позициях: {suma}");
    return find_sum_array;
}

void print_array(int[] print_array) //Объявляю функцию для принта созданного массива
{
    Console.Write("["); //Это будет скоба для начала вывода массива
    for (int i = 0; i < print_array.Length; i++)
    {
        Console.Write(print_array[i]);  //Печатается каждое значение индекса
        if (i < print_array.Length - 1)
        {
            Console.Write(", ");    //Проставляется запятая и пробел до момента длины заданного массива -1
        }
    }
    Console.WriteLine("]"); //Закрываею тоже скобкой.
}

gen_new_array();
print_array(array);
find_sum(array);