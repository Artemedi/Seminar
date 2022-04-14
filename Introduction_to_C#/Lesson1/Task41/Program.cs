//Задача 41: Пользователь вводит с клавиатуры или задает самостоятельно M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите произвольные числа или цифры");
string DigString = Convert.ToString(Console.ReadLine().Replace(" ", ""));  //Replace мы как-то на уроке нагуглили
char[] ch = DigString.ToCharArray(); //Конвертируем в массив
int CountDig = 0;   //Это будет длинной масива по цифрам
char[] ResultArray = new char[0]; //Добавляем массив для итога. В методе мы добавим ему длину
char[] NegativeArray = new char[0]; //Добавляем массив для итога. В методе мы добавим ему длину
int NegativCount = 0;

void CharString(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (Char.IsNumber(array[i]))    //Мог прописать последующую проверку, но тогда 0 попадёт в другой массив https://docs.microsoft.com/en-us/dotnet/api/system.char.isnumber?view=net-6.0
        {
            if (Char.GetNumericValue(array[i]) > 0) //Это кошмар. Я всю документацию перерыл https://docs.microsoft.com/en-us/dotnet/api/system.char?view=net-6.0
            {
                //Console.WriteLine($"Значение {array[i]} из строки явлется числом");
                Array.Resize(ref ResultArray, ResultArray.Length + 1); //Познакомился с Resize
                ResultArray[CountDig] = array[i];
                CountDig++;
            }
        }
        else
        {
            //Console.WriteLine($"Значение {array[i]} из строки не явлется числом");
            Array.Resize(ref NegativeArray, NegativeArray.Length + 1); //Познакомился с Resize
            NegativeArray[NegativCount] = array[i];
            NegativCount++;
        }
    }
    Console.WriteLine($"Количество цифр в строке: {CountDig}");
}


//CharString(WithoutSpace);
CharString(ch);
Console.Write("Массив из чисел в строке больше 0: ");
Console.Write(ResultArray);
Console.Write($" и состоит из {ResultArray.Length} значений.");
Console.WriteLine();
Console.Write("Массив из неподходящих символов в строке: ");
Console.Write(NegativeArray);
//Console.Write($" и длина массива {NegativeArray.Length}");

