using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp

{

    struct date

    {

        private int day; // день

        private int month; // месяц

        private int year; // год

        public int Day
        {
            get => day;
            set => day = value;
        }
        public int Month
        {
            get => month;
            set => month = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }

        public void init(int d, int m, int y) // метод создания

        {

            day = d;

            month = m;

            year = y;

        }

        public void enterD() // метод ввода

        {

            Console.Write("Введите дату: ");

            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц: ");

            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите год: ");

            year = Convert.ToInt32(Console.ReadLine());

        }

        public void print() // метод вывода

        {

            Console.WriteLine($"День: {day} Месяц: {month} Год: {year} ");

        }

        public int SCHET(date date1, date date2) //Метод рассчета дней между датами

        {

            int sum, sum1;

            if (date1.month < 3)
            {

                --date1.year;

                date1.month += 12;

            }

            sum = 365 * date1.year + date1.year / 4 - date1.year / 100 + date1.year / 400 +

            (153 * date1.month - 457) / 5 + date1.day - 306;

            if (date2.month < 3)
            {

                --date2.year;

                date2.month += 12;

            }

            sum1 = 365 * date2.year + date2.year / 4 - date2.year / 100 + date2.year / 400 +

            (153 * date2.month - 457) / 5 + date2.day - 306;

            if (sum < sum1)
            {

                return 0;

            }

            else

            {

                return sum - sum1;

            }

        }

    }

}