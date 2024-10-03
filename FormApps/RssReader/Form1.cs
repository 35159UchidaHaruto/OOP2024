using System;
using Microsoft.Web.WebView2.Core;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Windows.UI.Xaml.Controls.Primitives;
using System.Security.Cryptography;

namespace RssReader {

    public partial class form1 : Form {

        Dictionary<string, string> dataSource = new Dictionary<string, string> {
                       { "主要", "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
                       {"国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml"},
                       {"国際", "https://news.yahoo.co.jp/rss/topics/world.xml"},
                       { "経済", "https://news.yahoo.co.jp/rss/topics/business.xml"},
                       {"エンタメ", "https://news.yahoo.co.jp/rss/topics/entertainment.xml"},
                       {"スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml"},
                       { "IT","https://news.yahoo.co.jp/rss/topics/it.xml"},
                       {"科学", "https://news.yahoo.co.jp/rss/topics/science.xml"},
                       {"地域", "https://news.yahoo.co.jp/rss/topics/local.xml"} };


        List<ItemData> items;
        private EventHandler<CoreWebView2InitializationCompletedEventArgs> webView2_CoreWebView2InitializationCompleted;

        public form1() {
            InitializeComponent();
            //初期化完了時のイベント
            rssBrowser.CoreWebView2InitializationCompleted += webView2_CoreWebView2InitializationCompleted;

            rssBrowser.EnsureCoreWebView2Async(null);

            //cbRssName.DataSource = dataSource;
            cbRssName.DataSource = new BindingSource(dataSource, null);
            cbRssName.DisplayMember = "Key";
            cbRssName.ValueMember = "Value";
            this.Resize += new System.EventHandler(this.Form_Resize);

            cbRssName.SelectedIndex = -1;

        }


        private void Form_Resize(object sender, EventArgs e) {
            rssBrowser.Size = this.ClientSize - new System.Drawing.Size(rssBrowser.Location);
        }


        //取得ボタン
        private void btGet_Click(object sender, EventArgs e) {
            lbRssTitle.Items.Clear();
            var cbBoxinput = cbRssName.Text;

            if (cbRssName.Text.Contains("news.yahoo.co.jp/rss/")) {
                using (var wc = new WebClient()) {
                    var rssurl = wc.OpenRead(cbRssName.Text);
                    var xdoc = XDocument.Load(rssurl);

                    items = xdoc.Root.Descendants("item")
                                          .Select(item => new ItemData {
                                              Title = item.Element("title").Value,
                                              Link = item.Element("link").Value
                                          }).ToList();

                    foreach (var item in items) {

                        lbRssTitle.Items.Add(item.Title);
                    }
                }
            } else if (dataSource.ContainsKey(cbBoxinput)) {
                var selectedCategory = (KeyValuePair<string, string>)cbRssName.SelectedItem;
                var url = selectedCategory.Value;

                using (var wc = new WebClient()) {
                    var rssurl = wc.OpenRead(url);
                    var xdoc = XDocument.Load(rssurl);

                    items = xdoc.Root.Descendants("item")
                                          .Select(item => new ItemData {
                                              Title = item.Element("title").Value,
                                              Link = item.Element("link").Value
                                          }).ToList();

                    foreach (var item in items) {

                        lbRssTitle.Items.Add(item.Title);
                    }
                }
            } else {
                MessageBox.Show("正しいＵＲＬを入力してください。", "エラー",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //WebView2にWebページを投影
        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (rssBrowser != null && rssBrowser.CoreWebView2 != null) {
                rssBrowser.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);
            }

        }
        
        //登録ボタン
        private void bt_Favorite_Click(object sender, EventArgs e) {
            if (tbRssUrl.Text != null && cbRssName.Text.Contains("news.yahoo.co.jp/rss/")) {
                dataSource.Add(tbRssUrl.Text, cbRssName.Text);
                cbRssName.DataSource = new BindingSource(dataSource, null);
                cbRssName.DisplayMember = "Key";
                cbRssName.ValueMember = "Value";
            } else {
                MessageBox.Show("ＵＲＬとお気に入り名称を入力してください。", "エラー",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbRssUrl.Clear();
            cbRssName.SelectedIndex = -1;
        }
    }

    //データ格納用クラス
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }


}
