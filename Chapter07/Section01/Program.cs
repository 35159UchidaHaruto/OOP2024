using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

           var kenchou = new Dictionary<string, string>();

            Console.WriteLine("県庁所在地の登録");
            for (int i = 0; i < 2; i++) {
                Console.Write("都道府県：");
                var key = Console.ReadLine();
                Console.Write("県庁所在地：");
                var value = Console.ReadLine();

                if (key == kenchou[key]) {
                    Console.WriteLine("この都道府県は、既に登録されています。");
                    Console.WriteLine("上書きしますか？ y/n");
                    var c = Console.ReadLine();
                    if (c == "y"){
                        kenchou[key] = key;
                    }
                } else {
                    kenchou.Add(key, value);
                }
            }

            foreach(var ken in kenchou) {
                Console.WriteLine(ken.Key + "の県庁所在地は" + ken.Value + "です。");
            }                
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