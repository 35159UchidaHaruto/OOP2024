﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter {
    //オンス単位を表すクラス
    public class PoundUnit : WeightUnit {
        private static List<PoundUnit> units = new List<PoundUnit> {
           new PoundUnit{Name = "oz" ,Coefficient = 1,},
           new PoundUnit{Name = "lb" ,Coefficient = 16,}           
        };
        public static ICollection<PoundUnit> Units { get { return units; } }

        /// <summary>
        /// グラム単位からポンド単位に変換します
        /// </summary>
        /// <param name="unit">グラム単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>

        public double FromPoundUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient) / 0.45359237 / this.Coefficient;
        }
    }
}
