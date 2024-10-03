using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ブロック選択：　ALT+SHIFT
namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(110, "だいふく", 120);
            Product dorayaki = new Product(98, "どら焼き", 210);


            int price = karinto.Price; //税抜きの金額
            int taxIncluded = karinto.GetPriceIncludingTax(); //税込みの金額

            int daifukuprice = daifuku.Price;
            int daifukuTaxIncluded = daifuku.GetPriceIncludingTax();

            int dorayakiprice = dorayaki.Price;
            int dorayakiTax = dorayaki.GetTax();



            Console.WriteLine(karinto.Name + "の税込金額" + taxIncluded + 
                                                "円【税抜き" + price + "円】");

            Console.WriteLine(daifuku.Name + "の税込金額" + daifukuTaxIncluded +
                                                "円【税抜き" + daifukuprice + "円】");

            Console.WriteLine(dorayaki.Name + "の税込金額" + dorayakiTax +
                                    "円【税抜き" + dorayakiprice + "円】");

            Console.WriteLine($"{dorayakiTax}円");


        }
    }
}
