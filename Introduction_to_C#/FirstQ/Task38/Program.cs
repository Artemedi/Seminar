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


//38. Вариант с урока

// double[] array = {1.7,3.6,2.7,8.9};
// double[] Res(double[] diff){
//   double max = diff[0];
//   double min = diff[0];
//   for(int i=0; i < diff.Length; i++){
//     if(diff[i] > max){
//       max = diff[i];
//     }
//     else if (diff[i] < min){
//       min = diff[i];
//     }
//   }
//   Console.WriteLine($"{max},{min}");
//   return new double[] {max,min};
// }
// double[] newAr = Res(array);
// Console.WriteLine($"{newAr[0]} - {newAr[1]} = {newAr[0]} - {newAr[1]}");

// или так:

// // Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// using System.Text;

// //Создание массива вещественных чисел в диапазоне от MinValue до MaxValue
// double[] CreateDoubleArray(int Size, double MinValue = -10, double MaxValue = 10)
// {
//   double[] Result = new double[Size];

//   Random genNumber = new Random();
//   for (int i = 0; i < Size; i++)
//   {
//     Result[i] = MinValue + genNumber.NextDouble() * (MaxValue - MinValue);
//   }

//   return Result;
// }

// void PrintArray(double[] Array)
// {
//   String separator = ", ";
//   StringBuilder stringBuilder = new StringBuilder("[");
//   for (int i = 0; i < Array.Length - 1; i++)
//   {
//     stringBuilder.Append($"{Array[i]:f4}").Append(separator);
//   }
//   stringBuilder.Append($"{Array[Array.Length - 1]:f4}").Append("]");

//   Console.WriteLine(stringBuilder.ToString());
// }

// double CalcMaxMinDiffrence(double[] Array)
// {
//   double MinValue = Array[0];
//   double MaxValue = Array[0];

//   for (int i = 1; i < Array.Length; i++)
//   {
//     if (Array[i] < MinValue)
//     {
//       MinValue = Array[i];
//     }
//     else if (Array[i] > MaxValue)
//     {
//       MaxValue = Array[i];
//     }
//   }

//   return MaxValue - MinValue;
// }

// Console.Write("Введите размер массива: ");
// int ArrSize = Convert.ToInt32(Console.ReadLine());
// double[] Array = CreateDoubleArray(ArrSize);
// PrintArray(Array);

// double Diff = CalcMaxMinDiffrence(Array);
// Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Diff:f4}");