namespace RssReader {
    partial class form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.rssBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.cbRssName = new System.Windows.Forms.ComboBox();
            this.tbRssUrl = new System.Windows.Forms.TextBox();
            this.bt_Favorite = new System.Windows.Forms.Button();
            this.searchUrl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rssBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btGet.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(633, 20);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(78, 30);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.BackColor = System.Drawing.SystemColors.Window;
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(15, 107);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(309, 364);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // rssBrowser
            // 
            this.rssBrowser.AllowExternalDrop = true;
            this.rssBrowser.BackColor = System.Drawing.SystemColors.Window;
            this.rssBrowser.CreationProperties = null;
            this.rssBrowser.DefaultBackgroundColor = System.Drawing.SystemColors.Window;
            this.rssBrowser.Location = new System.Drawing.Point(335, 106);
            this.rssBrowser.Name = "rssBrowser";
            this.rssBrowser.Size = new System.Drawing.Size(471, 364);
            this.rssBrowser.TabIndex = 5;
            this.rssBrowser.ZoomFactor = 1D;
            // 
            // cbRssName
            // 
            this.cbRssName.FormattingEnabled = true;
            this.cbRssName.Location = new System.Drawing.Point(12, 30);
            this.cbRssName.Name = "cbRssName";
            this.cbRssName.Size = new System.Drawing.Size(612, 20);
            this.cbRssName.TabIndex = 6;
            // 
            // tbRssUrl
            // 
            this.tbRssUrl.Location = new System.Drawing.Point(12, 76);
            this.tbRssUrl.Name = "tbRssUrl";
            this.tbRssUrl.Size = new System.Drawing.Size(615, 19);
            this.tbRssUrl.TabIndex = 0;
            // 
            // bt_Favorite
            // 
            this.bt_Favorite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Favorite.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bt_Favorite.Location = new System.Drawing.Point(633, 70);
            this.bt_Favorite.Name = "bt_Favorite";
            this.bt_Favorite.Size = new System.Drawing.Size(78, 30);
            this.bt_Favorite.TabIndex = 7;
            this.bt_Favorite.Text = "登録";
            this.bt_Favorite.UseVisualStyleBackColor = false;
            this.bt_Favorite.Click += new System.EventHandler(this.bt_Favorite_Click);
            // 
            // searchUrl
            // 
            this.searchUrl.AutoSize = true;
            this.searchUrl.BackColor = System.Drawing.SystemColors.Menu;
            this.searchUrl.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.searchUrl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.searchUrl.Location = new System.Drawing.Point(12, 9);
            this.searchUrl.Name = "searchUrl";
            this.searchUrl.Size = new System.Drawing.Size(147, 13);
            this.searchUrl.TabIndex = 8;
            this.searchUrl.Text = "ＵＲＬ又は名称入力：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "お気に入り名称登録：";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(814, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchUrl);
            this.Controls.Add(this.bt_Favorite);
            this.Controls.Add(this.cbRssName);
            this.Controls.Add(this.rssBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbRssUrl);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rssBrowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 rssBrowser;
        private System.Windows.Forms.ComboBox cbRssName;
        private System.Windows.Forms.TextBox tbRssUrl;
        private System.Windows.Forms.Button bt_Favorite;
        private System.Windows.Forms.Label searchUrl;
        private System.Windows.Forms.Label label2;
    }
}

