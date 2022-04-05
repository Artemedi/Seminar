// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве

Console.Write("Введите желаемое количество элементов массива: ");
int[] array = new int[Math.Abs(Convert.ToInt32(Console.ReadLine()))]; //Задаем длину массива из введеного числа
int perem = array.Length;
int count = 0; //Устанавливаем переменную в 0. Она будет счётчиком
//int count2 = 0; //Устанавливаем переменную в 0. Она будет счётчиком для функции
//int[] new_array = new int[array.Length]; //Задаем длину массива для функции

Console.Write("Исходный массив: ");
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999); //Генерируем трехзнычные значение в объявленный массив
    Console.Write(array[i]);  //Выводим результат в строку
    if (i < array.Length - 1)
    {
        Console.Write(", ");    //Проставляется запятая и пробел до момента длины заданного массива -1
    }
}
Console.Write("]");
Console.WriteLine();    //Просто перенос строки
Console.Write("Чётные числа в массиве: ");
Console.Write("[");

bool zpt = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)   //Проверяем делится ли каждое число на 2
    {
        if(zpt)
        {
            Console.Write(", ");
        }
        Console.Write(array[i]);  //Выводим полученное значение в строку
        count++;    //Приблавяем счётчик на +1
        zpt = true;
    }
}
Console.Write("]");
Console.WriteLine();    //Просто перенос строки
Console.WriteLine($"Количество чётных чисел в массиве: {count}");

// Но раз задача была по тематике функций, то попробовал реализовать через них

void gen_new_array()
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
}

//Заполняю ранее созданный массив рандомными положительными цичлам от 100 до 999

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

int[] result_array(int[] massive)   //Объявляю функцию для вычисления чётных в массиве, но уже с указанием типа т.к. будет вывод
{
    count = 0;  //Выставляю переменную счётчика вновь в 0
    bool zpt = false;   //Не нашёл какого-то простого использования проставления разделителя кроме как на логику
    Console.Write("["); //Всё так же как и в прошлой функции со скобками
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 == 0)   //Проверяем делится ли каждое число на 2
        {
            if(zpt) //Проверка на логику. Изначально отрицательное, значит пусто
            {
                Console.Write(", ");
            }
            Console.Write(massive[i]);
            count++;    //Прибавляем счётчик на +1
            zpt = true; //Далее проставляем логику на Положительное и все последующие проверки будут такими же
        }
    }
    Console.WriteLine("]");
    return massive; //Возвращаем итоговое значение
}

gen_new_array();
Console.WriteLine();
Console.WriteLine($"Длина массива из функции: {array.Length}");
Console.Write($"Массив из функции: ");
print_array(array);
Console.Write($"Чётные числа в массиве из функции: ");
result_array(array);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");