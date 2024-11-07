﻿using SampleWeightUnitConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleWeightUnitConverter {
    public class MainWindowViewModel : ViewModel{
        private double gramValue, poundValue;
        
        //▲ボタンで呼ばれるコマンド
        public ICommand PoundUnitToGram { get; private set; }

        //▼ボタンで呼ばれるコマンド
        public ICommand PoundToGramUnit { get; private set; }

        //上のComboBoxで選択されている値
        public GramUnit CurrentGramUnit { get; set; }

        //下のComboBoxで選択されている値
        public PoundUnit CurrentPoundUnit { get; set; }

        public double GramValue {
            get { return gramValue; }
            set {
                gramValue = value;
                OnPropertyChanged();    //値が変更されたら通知
            }            
        }

        public double PoundValue {
            get { return poundValue; }
            set {
                poundValue = value;
                OnPropertyChanged();    //値が変更されたら通知
            }        
        }

        //コンストラクタ
        public MainWindowViewModel() {
            CurrentGramUnit = GramUnit.Units.First();
            CurrentPoundUnit = PoundUnit.Units.First();

            PoundUnitToGram = new DelegateCommand(() => 
                                  GramValue = CurrentGramUnit.FromGramUnit(CurrentPoundUnit,PoundValue));

            PoundToGramUnit = new DelegateCommand(() => 
                                  PoundValue = CurrentPoundUnit.FromPoundUnit(CurrentGramUnit, GramValue));
        }
    }
}
