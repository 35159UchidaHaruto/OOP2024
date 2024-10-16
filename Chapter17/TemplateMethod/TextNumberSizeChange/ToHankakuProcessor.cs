using TextNumberSizeChange.Properties.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextNumberSizeChange;

namespace TextNumberSizeChange {
    class ToHankakuProcessor : ITextFileService {
        private int _count;    
                
        public void Initialize(string fname) {
            _count = 0;
        }

        public void Execute(string line) {
            var output = new string(line.Select(c => (c >= '０') && (c <= '９') ? (char)(c - '０' + '0') : c).ToArray());
            Console.WriteLine(output);
        }

        public void Terminate() {
            Console.WriteLine("{0}行", _count);           
        }

    }
}
