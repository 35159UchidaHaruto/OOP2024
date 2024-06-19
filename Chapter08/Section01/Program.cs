using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var dt1 = new DateTime(2024,6,19);
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
            }
        }
    }
}
