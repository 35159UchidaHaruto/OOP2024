using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            //int count = numbers.Count(n => n % 2 == 0);
            double num = numbers.Where(n => n > 5 ).Average();
            int total = numbers.Where(n => n > 5).Sum();            
            Console.WriteLine(num);
            Console.WriteLine(total);           

            
        }        

        
    }
}

/*udgement judge = IsEven;
            //Judgement judge = IsNotEven;
            Judgement judge = IsNumOver;*/

/*nが偶数かどうかを調べる
        public static bool IsEven(int n) {
            return n % 2 == 0; //偶数だとtrueが返却される
        }

        //nが奇数かどうかを調べる
        public static bool IsNotEven(int n) {
            return n % 2 == 1;
        }

        //7より大きい数値があるかを調べる
        public static bool IsNumOver(int n) {
            return n > 7;
        }*/

/*public delegate bool Judgement(int value); //デリゲートの宣言

public static int Count(int[] numbers, Predicate<int> judge) {
    int count = 0;
    foreach (var n in numbers) {
        if (judge(n) == true) {
            count++;
        }
    }
    return count;
}*/