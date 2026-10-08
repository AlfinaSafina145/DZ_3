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
                Console.Write("Введите номер дня в году (от 1 до 365): ");
                int dayOfYear = int.Parse(Console.ReadLine());
                if (dayOfYear < 1 || dayOfYear > 365)
                {
                    throw new Exception("Число должно быть в диапазоне от 1 до 365.");
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