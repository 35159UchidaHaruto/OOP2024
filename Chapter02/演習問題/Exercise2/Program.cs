using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    public class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //インチからメートルへの対応表を出力
                PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
                PrintYardToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));
                PrintMeterToYardList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }

            private static void PrintInchToMeterList(int start, int stop) {
                for (int inch = start; inch <= stop; inch++) {
                    double meter = InchConverter.ToMeter(inch);
                    Console.WriteLine("{0} inch = {1:0.0000} m", inch, meter);
                }
            }

            private static void PrintMeterToInchList(int start, int stop) {
                for (int meter = start; meter <= stop; meter++) {
                    double inch = InchConverter.FromMeter(meter);
                    Console.WriteLine("{0} m = {1:0.0000} inch", meter, inch);
                }
            }

        private static void PrintYardToMeterList(int start, int stop) {
            for (int yard = start; yard <= stop; yard++) {
                double meter = YardConverter.ToMeter(yard);
                Console.WriteLine("{0} inch = {1:0.0000} m", yard, meter);
            }
        }

        private static void PrintMeterToYardList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double yard = YardConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} yard", meter, yard);
            }
        }

        public static double FromMeter(double meter) {
            return meter / 0.3048;
        }

        public static double ToMeter(double meter) {
            return meter / 0.3048;
        }
    }
}
