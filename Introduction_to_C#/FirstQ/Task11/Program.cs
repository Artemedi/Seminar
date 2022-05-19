//Задача 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

 Console.WriteLine("Ввести число в диапазоне от 10 до 99:");
 int numberN = Convert.ToInt32(Console.ReadLine());
 if (numberN >= 10 & numberN <= 99) 
 {
   int FirstDigit = numberN % 10;
   int SecondDigit = numberN / 10;
   if (FirstDigit == SecondDigit)
   {
     Console.WriteLine("Числа равны");
   } else if (FirstDigit > SecondDigit)
   {
     Console.WriteLine("Второе наибольшее");
   }else{
     Console.WriteLine("Первое наибольшее");
   }

 }
