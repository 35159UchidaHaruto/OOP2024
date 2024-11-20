using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
            


        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                ImagePath = CustomerImage.Source != null ? (CustomerImage.Source as BitmapImage)?.UriSource.AbsolutePath : null  //パスを保存
            };
            

            using(var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);                
            }
            ReadDatabase();//ListView表示
        }       

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();
                CustomerListView.ItemsSource = _customers;

            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var fiterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = fiterList;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;

            }

            using(var connection =new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);

                ReadDatabase();//ListView更新
            }

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            
            var item = CustomerListView.SelectedItem as Customer;
            if(item != null)
            // ユーザーが入力した新しい情報を反映
            item.Name = NameTextBox.Text;
            item.Phone = PhoneTextBox.Text;
            item.Address = AddressTextBox.Text;
            //SQLiteデータベースで更新を行う
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(item);  // 顧客情報を更新

            // ListViewを再読み込みして更新されたデータを表示
                ReadDatabase();
            }

        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            // ListViewで選択されたCustomerを取得
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {

                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
                if(!string.IsNullOrEmpty(selectedCustomer.ImagePath)){
                    CustomerImage.Source = new BitmapImage(new Uri(selectedCustomer.ImagePath));
                }
            }

        }

        //画像の保存
        private void PicSaveButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "画像ファイル(*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == true) {
                string filePath = openFileDialog.FileName;
                    // 画像を表示する
                    CustomerImage.Source = new BitmapImage(new Uri(filePath));                
            }
        }

        private void PicDeleteButton_Click(object sender, RoutedEventArgs e) {
            CustomerImage.Source = null;
        }
    }    
}
