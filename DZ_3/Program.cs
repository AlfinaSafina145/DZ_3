using System;

namespace Laba_Tumakov
{
    class Program
    {
        //для пункта 4
        enum WeekDay 
        {
            Понедельник = 1,
            Вторник = 2,
            Среда = 3,
            Четверг = 4,
            Пятница = 5,
            Суббота = 6,
            Воскресенье = 7
        }    
        static void Main(string[] args)
        {
            Console.WriteLine("Пункт 1");
            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            bool is_vozr = true;
            int violatorIndex = 0;
            for (int i = 1; i < 10; i++)
            {
                if (numbers[i] <= numbers[i - 1])
                {
                    is_vozr = false;
                    violatorIndex = i + 1;
                    break;
                }
            }
            if (is_vozr == true)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию");
            }
            else
            {
                Console.WriteLine("Последовательность не является упорядоченной!!!");
                Console.WriteLine($"Порядковый номер первого числа, нарушающего последовательность: {violatorIndex}");
            }
            Console.WriteLine();
            Console.WriteLine("Пункт 2");
            Console.WriteLine("Введите номер карты(от 6 до 14):");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 6 || number > 14)
                {
                    throw new Exception("Номер карты должен быть от 6 до 14!");
                }
                switch (number)
                {
                    case 6:
                        Console.WriteLine("Достоинство карты : шестерка");
                        break;
                    case 7:
                        Console.WriteLine("Достоинство карты : семерка");
                        break;
                    case 8:
                        Console.WriteLine("Достоинство карты : восмерка");
                        break;
                    case 9:
                        Console.WriteLine("Достоинство карты : девятка");
                        break;
                    case 10:
                        Console.WriteLine("Достоинство карты : десяткака");
                        break;
                    case 11:
                        Console.WriteLine("Достоинство карты : валет");
                        break;
                    case 12:
                        Console.WriteLine("Достоинство карты : дама");
                        break;
                    case 13:
                        Console.WriteLine("Достоинство карты : король");
                        break;
                    case 14:
                        Console.WriteLine("Достоинство карты : туз");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Вы ввели не число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка!: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Спасибо за попытку!");
            }
            Console.WriteLine();
            Console.WriteLine("Пункт 3");
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            string lower = input.ToLower();
            string drink = "Beer";
            if (lower == "jabroni")
            {
                drink = "Patron Tequilla";
            }
            else if (lower == "school counselor")
            {
                drink = "Anything with Alcohol";
            }
            else if (lower == "programmer")
            {
                drink = "Hipster Craft Beer";
            }
            else if (lower == "bike gang member")
            {
                drink = "Moonshine";
            }
            else if (lower == "politician")
            {
                drink = "Your tax dollars";
            }
            else if (lower == "rapper")
            {
                drink = "Cristal";
            }
            Console.WriteLine($"Ваш напиток: {drink}");
            Console.WriteLine();
            Console.WriteLine("Пункт 4");
            Console.WriteLine("Введите номер недели:");
            try
            {
                int dayNumber = int.Parse(Console.ReadLine());
                if (dayNumber < 1 || dayNumber > 7)
                {
                    throw new Exception("Ошибка!Введите число от 1 до 7");
                }
                WeekDay day = (WeekDay)dayNumber;
                Console.WriteLine($"День: {day}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели не число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Спасибо за попытку!");
            }
            Console.WriteLine();
            Console.WriteLine("Пункт 5");
            string[] toys = { "Hello Kitty", "Barbie doll", "Lego", "Hello Kitty", "Hello Kitty", "Transformer", "Barbie doll", "Ledo"};
            int bagCount = 0;
            foreach (string s in toys)
            {
                if (s == "Hello Kitty" || s == "Barbie doll")
                {
                    bagCount++;
                }
            }
            Console.WriteLine($"Количество кукол в сумке: {bagCount}");
        }
    }
}
