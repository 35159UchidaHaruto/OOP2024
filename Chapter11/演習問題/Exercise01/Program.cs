using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var xelements = xdoc.Root.Elements();

            foreach(var x in xelements) {
                var xname = x.Element("name");
                var xmember = x.Element("teammembers");
                Console.WriteLine("{0},{1}", xname.Value, xmember.Value);
            }
            
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var xelements = xdoc.Root.Elements()
                .OrderByDescending(x => (int)x.Element("firstplayed"));

            foreach(var x in xelements) {
                var xname = x.Element("name");
                var xkanji = xname.Attribute("kanji");
                var xyear = x.Element("firstplayed");
                Console.WriteLine("{0},{1}", xkanji.Value,xyear.Value);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load("sample.xml");
            var xelements = xdoc.Root.Elements()
                .OrderByDescending(x => x.Element("teammembers").Value).First();            
            Console.WriteLine("{0}",xelements.Element("name").Value);
        }

        private static void Exercise1_4(string file, string newfile) {
            
            List<XElement> xElements = new List<XElement>();
                        
            var xdoc = XDocument.Load(file);
            string name, kanji, member, origin;
            int nextFlag;

            while (true) { 
                Console.Write("名称:");
                name = Console.ReadLine();
                Console.Write("漢字:");
                kanji = Console.ReadLine();
                Console.Write("人数:");
                member = Console.ReadLine();
                Console.Write("起源:");
                origin = Console.ReadLine();
                
                //１件分の要素作成
                var element = new XElement("ballsport",
                    new XElement("name", name, new XAttribute("kanji", kanji)),
                    new XElement("teammembers", member),
                    new XElement("firstplayed", origin));
                xElements.Add(element); //リストへ要素を追加
                
                Console.WriteLine();//改行                
                Console.Write("追加 (1),保存 (2) :");
                Console.Write(">");
                nextFlag = int.Parse(Console.ReadLine());
                if (nextFlag == 2) break;
                Console.WriteLine();//改行                
            }
            xdoc.Root.Add(xElements);
            xdoc.Save(newfile); //保存                       
        }
    }
}
