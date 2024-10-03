using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();        
        static void Main(string[] args) {
            String pref, prefCaptalLocation;
            //入力処理
            Console.WriteLine("県庁所在地の登録");
            while (true) {
                //都道府県の入力
                Console.Write("都道府県：");
                pref = Console.ReadLine();

                if(pref == null) {
                    break;
                }

                //県庁所在地の入力
                Console.Write("県庁所在地：");
                prefCaptalLocation = Console.ReadLine();               

                //既に都道府県が登録されているか？
                if (prefOfficeDict.ContainsKey(pref)) {
                    //登録済み
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if (Console.ReadLine() == "N") {
                        continue;
                    }
                }
                prefOfficeDict[pref] = prefCaptalLocation;
            }
            Console.WriteLine();

            Boolean endFlag = false; //終了フラグ(無限ループを抜け出す用）
            while (!endFlag) {               
                switch (menuDisp()) {
                    //一覧出力処理
                    case "1":
                        listDisplay();
                        break;

                    //検索処理
                    case "2":
                        serach();
                        break;
                    
                    case "9":
                        endFlag = true; //終了フラグＯＮ
                        break;
                }
                if (endFlag) {
                    break;
                }

            }

        }

        private static void serach() {
            //都道府県の入力
            Console.WriteLine("都道府県:");
            String searchPref = Console.ReadLine();
            Console.WriteLine(searchPref + "の都道府県は" + prefOfficeDict[searchPref] + "です");
        }

        //一覧表示処理
        private static void listDisplay() {            
            foreach (var item in prefOfficeDict) {
                Console.WriteLine("{0}の県庁所在地は{1}です", item.Key, item.Value);
            }
        }


        //menu表示
        private static string menuDisp() {
            Console.WriteLine("**** メニュー ****");
            Console.WriteLine("1.一覧表示:");
            Console.WriteLine("2.検索");
            Console.WriteLine("9.終了");
            Console.Write(">");
            String menuSelect = Console.ReadLine();
            return menuSelect;
        }
    }
}

/*var employeeDict = new Dictionary<int, Employee> {
               { 100, new Employee(100, "清水遼久") },
               { 112, new Employee(112, "芹沢洋和") },
               { 125, new Employee(125, "岩瀬奈央子") },
            };

            employeeDict.Add(126, new Employee(126, "庄野和花"));


            foreach (var item in employeeDict.Keys) {
                Console.WriteLine($"{item}");
            }*/