using System;

namespace Laboratory_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int day_data;
            int month_data;
            int year_data;
            DateTime today_data = DateTime.Today;
            DateTime person_data;

            /*ПРИВЕТСТВИЕ*/
            Console.WriteLine("Приветствую вас! ");
            Console.ReadKey();
            Console.WriteLine("Пожалуйста, ответьте на вопросы анкеты ");
            Console.ReadKey();
            /*----------------------*/

            /*ИМЯ ПОЛЬЗОВАТЕЛЯ*/
            Console.Write("Ваше имя: ");
            name = Convert.ToString(Console.ReadLine());
            /*----------------------*/

            /*ДЕНЬ РОЖДЕНИЯ ПОЛЬЗОВАТЕЛЯ*/
            Console.Write("Ваш день рождения: ");
            day_data = Convert.ToInt32(Console.ReadLine());
            while (day_data > 31 || day_data < 1)
            {
                Console.WriteLine("Введите корректное число");
                Console.Write("Ваш день рождения: ");
                day_data = Convert.ToInt32(Console.ReadLine());
            }
            /*----------------------*/

            /*МЕСЯЦ РОЖДЕНИЯ ПОЛЬЗОВАТЕЛЯ*/
            Console.Write("Ваш месяц рождения: ");
            month_data = Convert.ToInt32(Console.ReadLine());
            while (month_data > 12 || month_data < 1)
            {
                Console.WriteLine("Введите корректное число");
                Console.Write("Ваш месяц рождения: ");
                month_data = Convert.ToInt32(Console.ReadLine());
            }
            /*----------------------*/

            /*ГОД РОЖДЕНИЯ ПОЛЬЗОВАТЕЛЯ*/
            Console.Write("Ваш год рождения: ");
            year_data = Convert.ToInt32(Console.ReadLine());
            /*----------------------*/

            /*ВЫСЧЕТ ВОЗРАСТА ПОЛЬЗОВАТЕЛЯ*/
            person_data = new DateTime(year_data, month_data, day_data);
            TimeSpan interval = today_data - person_data;
            /*----------------------*/

            /*ОТВЕТ*/
            /*ЕСЛИ ПОЛЬЗОВАТЕЛЮ БОЛЬШЕ 60 ЛЕТ*/
            if(year_data <= 1960)
            {
                Console.Write("Привет, " + name + ". Ваш возраст равен ");
                Console.Write(Math.Floor(interval.TotalDays / 365));
                Console.Write(" лет. К сожалению, вы слишком стары!");
            }
            /*ЕСЛИ ПОЛЬЗОВАТЕЛЮ МЕНЬШЕ 18 ЛЕТ*/
            else if(year_data >= 2002)
            {
                Console.Write("Привет, " + name + ". Ваш возраст равен ");
                Console.Write(Math.Floor(interval.TotalDays / 365));
                Console.Write(" лет. Ваш опыт работы слишком мал!");
            }
            /*В ИНЫХ ЖЕ СЛУЧАЯХ*/
            else
            {
                Console.Write("Привет, " + name + ". Ваш возраст равен ");
                Console.Write(Math.Floor(interval.TotalDays / 365));
                Console.Write(" лет. Приятно познакомиться!");
            }
            /*----------------------*/
            Console.ReadKey();

        }
    }
}
