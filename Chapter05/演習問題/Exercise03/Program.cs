using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";            


            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            Console.WriteLine("-----");

            Console.WriteLine("-----");
            Exercise3_6(text);
            

        }        

        private static void Exercise3_1(string text) {
            int count = 0;
            foreach (var c in text) {
                if (c == ' ') {
                    count++;
                }
            }
            Console.WriteLine("空白文字数:" + count);
        }

        private static void Exercise3_2(string text) {

            var c = text.Replace("big", "small");
            Console.WriteLine(c);
        }

        private static void Exercise3_3(string text) {
           var count  = text.Split().Length;
            Console.WriteLine(count);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split().Where(s => s.Length <= 4);
            foreach(var word in words) {
                Console.WriteLine(word);
            }            
        }

        private static void Exercise3_5(string text) {
            var words = text.Split(' ').ToArray();
            if (words.Length > 0) {
                var sb = new StringBuilder(words[0]);
                foreach (var word in words.Skip(1)) {
                    sb.Append(word).Append(' ');
                }
                Console.Write(sb);
            }
        }

        private static void Exercise3_6(string text) {
            var words = text.Split((new[] { ',', ' ', '-', '_' }).ToArray());
            foreach (var word in words) {
                Console.Write(word);
            }            
        }
    }
}
