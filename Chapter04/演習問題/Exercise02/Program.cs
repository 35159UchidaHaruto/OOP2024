using Exercise01;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            // 4.2.1
            var ymCollection = new YearMonth[] {
            new YearMonth(1980, 1),
            new YearMonth(2000, 4),
            new YearMonth(2001,11),
            new YearMonth(2005, 3),
            new YearMonth(2020, 12),
            };

            // 4.2.2
            Console.WriteLine("\n- 4.2.2 ---");
            Exercise2_2(ymCollection);                    
            
            // 4.2.4
            Console.WriteLine("\n- 4.2.4 ---");
            Exercise2_4(ymCollection);

            // 4.2.5
            Console.WriteLine("\n- 4.2.5 ---");            
            Exercise2_5(ymCollection);
        }        

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection)
            {
               Console.WriteLine(ym);
            }
        }

        //4.2.3(4.2.4で呼び出されるメソッド)
        private static YearMonth FindFirst21C(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                if (ym.Is21Century) {
                    return ym;
                }                
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {            
            
                /*var ym = FindFirst21C(ymCollection);
            if (ym != null) {
                Console.WriteLine(ym.Year);
            }else { 
                Console.WriteLine("21世紀のデータはありません。");
            }*/

            var ym = FindFirst21C(ymCollection);
            Console.WriteLine(ym == null ? "21世紀のデータはありません。": ym.ToString());
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {

            foreach (var vm in ymCollection) {
                Console.WriteLine(vm);
            }

            Console.WriteLine();

            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach(var ym in array) {
                Console.WriteLine(ym);
            }                
        }
    }
}
