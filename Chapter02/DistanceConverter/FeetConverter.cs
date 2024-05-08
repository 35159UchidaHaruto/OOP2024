using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class FeetConverter {
        //フィートからメートルを求める
        public double FeetFromMeter(int feet) {
            return feet * 0.3048;
        }
        //メートルからフィートを求める
        public double MeterToFeet(int meter) {
            return meter / 0.3048;
        }
    }
}
