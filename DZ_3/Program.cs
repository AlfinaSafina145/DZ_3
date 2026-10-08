using System;
namespace Myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня","июля", "августа", "сентября", "октября", "ноября", "декабря" };
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            int dayOfYear = int.Parse(Console.ReadLine());
            int monthIndex = 0;
            while (dayOfYear > daysInMonths[monthIndex])
            {
                dayOfYear -= daysInMonths[monthIndex];
                monthIndex++;
            }
            Console.WriteLine($"{dayOfYear} {monthNames[monthIndex]}");
        }
    }
}

