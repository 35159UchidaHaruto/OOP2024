using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        Mycolor currentColor; //現在設定している色情報

        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値を設定(起動後すぐにストックボタンが押された場合の対応)
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);
            var colors = typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static);
            DataContext = GetColorList();
        }

        //スライドを動かすと呼ばれるイベントハンドラ
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {                      
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);           
            colorArea.Background = new SolidColorBrush(currentColor.Color);            
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            currentColor.Name = GetColorList().Where(c => c.Color == currentColor.Color).Select( c=> c.Name).FirstOrDefault();
            //既に登録されている場合は登録しない
            if (!stockList.Items.Contains(currentColor)) {
                stockList.Items.Insert(0, currentColor);            
            } else {
                MessageBox.Show("既に登録済みです。");
            }            
            colorSelectComboBox.SelectedIndex = -1;
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(stockList.SelectedIndex != -1) {
                colorArea.Background = new SolidColorBrush(((Mycolor)stockList.Items[stockList.SelectedIndex]).Color);
                setSliderValue(((Mycolor)stockList.Items[stockList.SelectedIndex]).Color);
               
            }           
        }

        //色スライダーの値を設定する
        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;            
        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private Mycolor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new Mycolor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (colorSelectComboBox.SelectedIndex != -1) {
                var tempCurrentColor= currentColor = (Mycolor)((ComboBox)sender).SelectedItem;
                
                //各スライダーの値を設定する
                setSliderValue(currentColor.Color);
                currentColor.Name = tempCurrentColor.Name; //Nameプロパティの文字列を設定
               
                
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e) {            
            if (stockList.SelectedIndex != -1) {
                var i = stockList.SelectedIndex;
                stockList.Items.RemoveAt(i);
                currentColor.Color = Color.FromRgb(0, 0, 0);
                colorArea.Background = new SolidColorBrush(currentColor.Color);                
                setSliderValue((Color)currentColor.Color);
            }
        }
    }
}