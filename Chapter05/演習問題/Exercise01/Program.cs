using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("文字を入力してください。：");
            var s = Console.ReadLine();
            Console.WriteLine();
            Console.Write("文字を入力してください。：");
            var s2 = Console.ReadLine();        

            if(String.Compare(s, s2, true) == 0){
                Console.WriteLine("等しいです。");
            } else {
                Console.WriteLine("等しくないです。");
            }

        }
    }
}
