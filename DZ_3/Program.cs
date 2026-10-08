using System;

namespace Myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            try
            {
                Console.Write("Введите год: ");
                int year = int.Parse(Console.ReadLine());
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    daysInMonths[1] = 29;
                    Console.WriteLine("Год високосный. В феврале 29 дней.");
                }
                else
                {
                    Console.WriteLine("Год не високосный. В феврале 28 дней.");
                }
                Console.Write("Введите номер дня в году (от 1 до 365 или 366): ");
                int dayOfYear = int.Parse(Console.ReadLine());
                int maxDays = 0;
                for (int i = 0; i < daysInMonths.Length; i++)
                {
                    maxDays += daysInMonths[i];
                }
                if (dayOfYear < 1 || dayOfYear > maxDays)
                {
                    throw new Exception($"Число должно быть в диапазоне от 1 до {maxDays}.");
                }
                int monthIndex = 0;
                while (dayOfYear > daysInMonths[monthIndex])
                {
                    dayOfYear -= daysInMonths[monthIndex];
                    monthIndex++;
                }
                Console.WriteLine($"{dayOfYear} {monthNames[monthIndex]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Это НЕ число! Введите целое число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Спасибо за попытку!");
            }
        }
    }
}
