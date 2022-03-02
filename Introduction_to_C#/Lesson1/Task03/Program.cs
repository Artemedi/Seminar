// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
string[] array = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите индекс для дня недели - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(array[number]);