//44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
	double number = 1000;
        double firstElem = 1;
        double secondElem = 1;

        Console.WriteLine($"1. {firstElem}");
        Console.WriteLine($"2. {secondElem}");

        for (int i = 3; i <= number; i++)
        {
            double nextElem = firstElem + secondElem;
            Console.WriteLine($"{i}. {nextElem}");
            firstElem = secondElem;
            secondElem = nextElem;
        }
