using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {            

            Console.WriteLine("生年月日を入力してください");
            Console.Write("年：");
            int year = int.Parse(Console.ReadLine());
            Console.Write("月：");
            int month = int.Parse(Console.ReadLine());
            Console.Write("日：");
            int day = int.Parse(Console.ReadLine());

            var birthday = new DateTime(year, month, day);
            DayOfWeek dayOfWeek = birthday.DayOfWeek;

            switch (dayOfWeek) {
                case DayOfWeek.Monday:
                    Console.WriteLine("月曜日です。");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("火曜日です。");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("水曜日です。");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("木曜日です。");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("金曜日です。");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("土曜日です。");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("日曜日です。");
                    break;
            }


        }
    }
}

/*var dt1 = new DateTime(2024,6,19);
           var dt2 = new DateTime(2005, 3, 2, 12, 00, 00);
           Console.WriteLine(dt1);
           Console.WriteLine(dt2);


           var today = DateTime.Today;            
           var now = DateTime.Now;
           Console.WriteLine("today :{0}",today);
           Console.WriteLine("now : {0}", now);

           var isLeapYear = DateTime.IsLeapYear(2000);
           if (isLeapYear) {
               Console.WriteLine("閏年です。");
           }else {
               Console.WriteLine("閏年ではありません。");
           }*/
