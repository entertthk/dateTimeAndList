using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson91
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //küsi synnipeäv ja arvuta vanus sekundites
            /*
            var dateToday = new DateTime(1981, 11, 1);
            Console.WriteLine(dateToday);
            var dayOfTheWeek = dateToday.DayOfWeek;
            Console.WriteLine(dayOfTheWeek);
            */

            
            var currentDate = DateTime.Now;  //tänane kuupäev
            var dateObject = new DateTime(2019, 11, 01);
            Console.WriteLine(currentDate);


            var currentDayOfTheWeek = currentDate.DayOfWeek;
            Console.WriteLine(currentDayOfTheWeek);

            var ticks = dateObject.Ticks; // seconds since 1970 jan 1
            Console.WriteLine($"Ticks {ticks}");

            Console.WriteLine($"Print current date: {currentDate}");
            Console.WriteLine($"Print long date string: {currentDate.ToLongDateString()}");
            Console.WriteLine($"Print short date string: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Print long time string: {currentDate.ToLongTimeString()}");
            Console.WriteLine($"Print short time string: {currentDate.ToShortTimeString()}");
            Console.WriteLine($"Date format: {currentDate.ToString("dd-MM-yyyy HH:mm")}"); //MM month, mm- minutes

            string userInfo;
            Console.WriteLine("Enter your date of birth: (yyyy/mm/dd) ");
            userInfo = Console.ReadLine();


            separateDate(userInfo);

            Console.ReadLine();
        }

        public static void separateDate(string list)

        {
            string[] userList = list.Split ('/');


            int year = int.Parse(userList[0]); //teeb uue muutuja massiivist
            int month = int.Parse(userList[1]);
            int day = int.Parse(userList[2]);

            var userBirthday = new DateTime(year, month, day);
            Console.WriteLine(userBirthday);
            var birthdayOfTheWeek = userBirthday.DayOfWeek;
            Console.WriteLine($"day: {birthdayOfTheWeek}");

            //var userBirthday = new DateTime(int.Parse(userList[0]), int.Parse(userList[1]), int.Parse(userList[2]) ); //sama asi mis üleval aga kõik ühel real
            //Console.WriteLine($"year: {userBirthday}");
            //var dayOfThe = userBirthday.DayOfWeek;
            //Console.WriteLine($"day: {dayOfThe}");
        }

    }
}
