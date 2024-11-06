using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter {
    //グラム単位を表すクラス
    public class GramUnit : WeightUnit {
        private static List<GramUnit> units = new List<GramUnit> {
           new GramUnit{Name = "g" ,Coefficient = 0.001,},
           new GramUnit{Name = "kg" ,Coefficient = 1,}          
        };
        public static ICollection<GramUnit> Units { get { return units; } }

        /// <summary>
        /// ポンド単位からグラム単位に変換します
        /// </summary>
        /// <param name="unit">ポンド単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>

        public double FromGramUnit(PoundUnit unit, double value) {
            return (value * unit.Coefficient) * 0.045/ this.Coefficient;
        }
    }
}
