// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите желаемое количество элементов массива: ");
int[] array = new int[Math.Abs(Convert.ToInt32(Console.ReadLine()))]; //Задаем длину массива из введеного числа

void gen_new_array()    //Заполняем массив рандомными значениями
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
}

void print_array(int[] print_array) //Объявляю функцию для принта созданного массива
{
    bool zpt = false;   //Вновь добавляем логику
    Console.Write("["); //Это будет скоба для начала вывода массива
    for (int i = 0; i < print_array.Length; i++)
    {
        if (zpt)
        {
            Console.Write(", ");    //Проставляется запятая и пробел до момента длины заданного массива
        }
        Console.Write(print_array[i]);  //Печатается каждое значение индекса
        zpt = true;
    }
    Console.WriteLine("]"); //Закрываю тоже скобкой.
}

void FindInArray(int[] FindInArray)
{
    int Min = FindInArray[0];
    int Max = FindInArray[0];
    for (int i = 0; i < FindInArray.Length; i++)
    {
        if (Max > FindInArray[i])
        {
            Min = FindInArray[i];
            
        }
        else
        {
            Max = FindInArray[i];
        }
    }
    Console.WriteLine($"Минимальное число: {Min}");
    Console.WriteLine($"Максимальное число: {Max}");
    Console.WriteLine($"Разница между ними: {Max - Min}");
}

gen_new_array();
print_array(array);
FindInArray(array);