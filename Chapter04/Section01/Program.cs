using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            #region null 条件演算子

            #endregion
            
            Console.Write("整数を入力:");
            string inputNum = Console.ReadLine();
            int num;
            if (int.TryParse(inputNum, out num)) {
                
                Console.WriteLine("整数に変換した値:" + num);
            }else {
                Console.WriteLine("変換に失敗しました。");
            }
            



            /*private static object GetMessage(string code) {
            return null;
            }*/

            /*private static object DefaultMessage() {
                return "Defalut Message";
            }*/
        }
    }
}
            #region null合体演算子
            /*string code = "12345";
            var message = GetMessage(code) ?? DefaultMessage();
            Console.WriteLine(message);*/
            #endregion
