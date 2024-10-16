using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineCounter;

namespace LineCounter {
     class Program {
        static void Main(string[] args) {
            LineCounter.Run<LineCounterProcessor>(args[0]);
        }
    }
}
