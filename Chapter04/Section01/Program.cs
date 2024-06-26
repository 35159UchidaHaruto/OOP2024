﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            #region null合体演算子
            //string code = "12345";
            //var message = GetMessage(code) ?? DefaultMessage();
            //Console.WriteLine(message);
            #endregion

            #region null条件演算子
            //Sale sale = new Sale {
            //    Amount = 1000,
            //};
            //Sale sale = null;

            //「int?」はnull許容型、「?.」はnull条件演算子
            //int? ret = sale?.Amount;
            //Console.WriteLine(ret);
            #endregion


            Console.Write("整数を入力：");
            string inputNum = Console.ReadLine();

            try {
                int num = int.Parse(inputNum);
            }
            catch (FormatException ex) {
                Console.WriteLine("FormatException"　+ ex.Message);
            }
            catch(ArgumentException ex) { 
                Console.WriteLine("ArgumentException" +  ex.Message);
            }
            catch(OverflowException ex) {
                Console.WriteLine("OverflowException" + ex.Message);
            }
            finally {
                Console.WriteLine("処理が完了しました。");
            }          
            
        }

        private static object GetMessage(string code) {
            return null;
        }
        
        private static object DefaultMessage() {
            return "Default Message";
        }


    }
    //売り上げクラス
    public class Sale {
        //店舗名
        public string ShopName { get; set; }
        //商品カテゴリ
        public string ProductCategory { get; set; }
        //売上高
        public int Amount { get; set; }
    }

}
