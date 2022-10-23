using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Polyakova.TaskZodiac
{
    public class Zodiac
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ZodiacSign ZodiacSign { get; set; }
        public int[] DateOfBirh { get; set; }

        public Zodiac(string lastName, string firstName, int[] dateOfBirh)
        {
            LastName = lastName;
            FirstName = firstName;
            DateOfBirh = dateOfBirh;

            ZodiacSign = GetSignDate(DateOfBirh);
        }

        public static Zodiac[] GetZodiacArray()
        {
            int numberOfPeople = 0;
            string input;
            do
            {
                Console.Write("Введите количество людей: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out numberOfPeople));
            Zodiac[] zodiacs = new Zodiac[numberOfPeople];

            for (int i = 0; i < zodiacs.Length; i++)
            {
                int[] dateOfBirth = new int[3];
                Console.Write("Введите имя: ");
                string firstName = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Введите дату рождения: ");
                Console.Write("День: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Месяц: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Год: ");
                int year = Convert.ToInt32(Console.ReadLine());
                dateOfBirth[0] = day;
                dateOfBirth[1] = month;
                dateOfBirth[2] = year;
                zodiacs[i] = new Zodiac(lastName, firstName, dateOfBirth);
            }
            return zodiacs;
        }

        private ZodiacSign GetSignDate(int[] dateOfBirth)
        {
            var day = dateOfBirth[0];
            var month = dateOfBirth[1];

            if ((day >= 21 && month == 3)(day <= 20 && month == 4))
                return ZodiacSign.Aries;

            if ((day >= 21 && month == 4)(day <= 20 && month == 5))
                return ZodiacSign.Taurus;

            if ((day >= 21 && month == 5)(day <= 21 && month == 6))
                return ZodiacSign.Twins;

            if ((day >= 22 && month == 6)(day <= 22 && month == 7))
                return ZodiacSign.Crayfish;

            if ((day >= 23 && month == 7)(day <= 22 && month == 8))
                return ZodiacSign.Leo;

            if ((day >= 23 && month == 8)(day <= 23 && month == 9))
                return ZodiacSign.Virgin;

            if ((day >= 24 && month == 9)(day <= 23 && month == 10))
                return ZodiacSign.Libra;

            if ((day >= 24 && month == 10)(day <= 22 && month == 11))
                return ZodiacSign.Scorpio;

            if ((day >= 23 && month == 11)(day <= 21 && month == 12))
                return ZodiacSign.Sadittarius;

            if ((day >= 22 && month == 12)(day <= 20 && month == 1))
                return ZodiacSign.Capricorn;

            if ((day >= 21 && month == 1) || (day <= 18 && month == 2))
                return ZodiacSign.Aquarius;
            else
                return ZodiacSign.Pisces;
        }
        public string ZodiacSignToString(ZodiacSign zodiacSign)
        {
            switch (zodiacSign)
            {
                case ZodiacSign.Aries: return "Овен";
                case ZodiacSign.Taurus: return "Телец";
                case ZodiacSign.Twins: return "Близнецы";
                case ZodiacSign.Crayfish: return "Рак";
                case ZodiacSign.Leo: return "Лев";
                case ZodiacSign.Virgin: return "Дева";
                case ZodiacSign.Libra: return "Весы";
                case ZodiacSign.Scorpio: return "Скорпион";
                case ZodiacSign.Sadittarius: return "Стрелец";
                case ZodiacSign.Capricorn: return "Козерог";
                case ZodiacSign.Aquarius: return "Водолей";
                case ZodiacSign.Pisces: return "Рыбы";
            }
            return null;
        }
        public override string ToString()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}, Дата рождения: {DateOfBirh[0]}.{DateOfBirh[1]}.{DateOfBirh[2]}, {ZodiacSignToString(ZodiacSign)}";
        }


    }
}