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
            var element = new XElement("ballsport",
                new XElement("name","サッカー",new XAttribute("kanji","蹴球")),
                new XElement("teammembers","11"),
                new XElement("firstplayed", "1863"));
            
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);


            // これ以降は確認用のコード 
            foreach (var xsports in xdoc.Root.Elements()) {
                var xname = xsports.Element("name");
                var xfirstplayed = xsports.Element("firstplayed");
                Console.WriteLine("{0} {1}", xname.Value, xfirstplayed.Value);
            }
            xdoc.Save(newfile);           
        }
    }
}
