namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            cbAuthor = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbCarName = new ComboBox();
            label5 = new Label();
            rbToyota = new RadioButton();
            rbNissan = new RadioButton();
            rbHonda = new RadioButton();
            rbSubaru = new RadioButton();
            rbImporter = new RadioButton();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            tbReport = new TextBox();
            btModifyReport = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            label6 = new Label();
            btAddReport = new Button();
            btPicOpen = new Button();
            btDelete = new Button();
            dgvCarReport = new DataGridView();
            btReportOpen = new Button();
            btReportSave = new Button();
            label7 = new Label();
            ofdPicFileOpen = new OpenFileDialog();
            ssMessageArea = new StatusStrip();
            tslbMessage = new ToolStripStatusLabel();
            ofdReportFileOpen = new OpenFileDialog();
            sfdReportFileSave = new SaveFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            ssMessageArea.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(567, 23);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "画像";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(129, 27);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 33);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(31, 93);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(129, 86);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(344, 38);
            cbAuthor.TabIndex = 2;
            cbAuthor.TextChanged += cbAuthor_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(31, 160);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(31, 224);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(129, 216);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(344, 38);
            cbCarName.TabIndex = 2;
            cbCarName.TextChanged += cbCarName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(31, 303);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(27, 22);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(94, 22);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 0;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(163, 22);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 0;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(222, 22);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 0;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbImporter
            // 
            rbImporter.AutoSize = true;
            rbImporter.Location = new Point(282, 22);
            rbImporter.Name = "rbImporter";
            rbImporter.Size = new Size(61, 19);
            rbImporter.TabIndex = 0;
            rbImporter.Text = "輸入車";
            rbImporter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImporter);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(129, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 51);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Checked = true;
            rbOther.Location = new Point(361, 22);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 1;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbReport.Location = new Point(129, 290);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(417, 148);
            tbReport.TabIndex = 4;
            // 
            // btModifyReport
            // 
            btModifyReport.Font = new Font("Yu Gothic UI", 14F);
            btModifyReport.Location = new Point(678, 325);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(83, 44);
            btModifyReport.TabIndex = 5;
            btModifyReport.Text = "修正";
            btModifyReport.UseVisualStyleBackColor = true;
            btModifyReport.Click += btModifyReport_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btPicDelete.Location = new Point(777, 19);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(80, 29);
            btPicDelete.TabIndex = 6;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.White;
            pbPicture.Location = new Point(567, 56);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(309, 246);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 7;
            pbPicture.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(31, 27);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 0;
            label6.Text = "日付";
            // 
            // btAddReport
            // 
            btAddReport.Font = new Font("Yu Gothic UI", 14F);
            btAddReport.Location = new Point(577, 325);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(84, 44);
            btAddReport.TabIndex = 5;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = true;
            btAddReport.Click += btAddReport_Click;
            // 
            // btPicOpen
            // 
            btPicOpen.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btPicOpen.Location = new Point(651, 19);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(85, 29);
            btPicOpen.TabIndex = 5;
            btPicOpen.Text = "開く…";
            btPicOpen.UseVisualStyleBackColor = true;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDelete.Location = new Point(777, 325);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(86, 44);
            btDelete.TabIndex = 8;
            btDelete.Text = "削除";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // dgvCarReport
            // 
            dgvCarReport.AllowUserToAddRows = false;
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(129, 472);
            dgvCarReport.MultiSelect = false;
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.RowHeadersVisible = false;
            dgvCarReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarReport.Size = new Size(756, 194);
            dgvCarReport.TabIndex = 9;
            dgvCarReport.Click += dgvCarReport_Click;
            // 
            // btReportOpen
            // 
            btReportOpen.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btReportOpen.Location = new Point(38, 561);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(85, 39);
            btReportOpen.TabIndex = 10;
            btReportOpen.Text = "開く…";
            btReportOpen.UseVisualStyleBackColor = true;
            btReportOpen.Click += btReportOpen_Click;
            // 
            // btReportSave
            // 
            btReportSave.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btReportSave.Location = new Point(38, 612);
            btReportSave.Name = "btReportSave";
            btReportSave.Size = new Size(85, 39);
            btReportSave.TabIndex = 10;
            btReportSave.Text = "保存";
            btReportSave.UseVisualStyleBackColor = true;
            btReportSave.Click += btReportSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(58, 485);
            label7.Name = "label7";
            label7.Size = new Size(55, 30);
            label7.TabIndex = 11;
            label7.Text = "一覧";
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // ssMessageArea
            // 
            ssMessageArea.Items.AddRange(new ToolStripItem[] { tslbMessage });
            ssMessageArea.Location = new Point(0, 723);
            ssMessageArea.Name = "ssMessageArea";
            ssMessageArea.Size = new Size(892, 22);
            ssMessageArea.TabIndex = 12;
            ssMessageArea.Text = "statusStrip1";
            // 
            // tslbMessage
            // 
            tslbMessage.Name = "tslbMessage";
            tslbMessage.Size = new Size(0, 17);
            // 
            // ofdReportFileOpen
            // 
            ofdReportFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 745);
            Controls.Add(ssMessageArea);
            Controls.Add(label7);
            Controls.Add(btReportSave);
            Controls.Add(btReportOpen);
            Controls.Add(dgvCarReport);
            Controls.Add(btDelete);
            Controls.Add(pbPicture);
            Controls.Add(btPicDelete);
            Controls.Add(btAddReport);
            Controls.Add(btPicOpen);
            Controls.Add(btModifyReport);
            Controls.Add(tbReport);
            Controls.Add(groupBox1);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(dtpDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "試乗レポート管理システム";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            ssMessageArea.ResumeLayout(false);
            ssMessageArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private ComboBox cbAuthor;
        private Label label3;
        private Label label4;
        private ComboBox cbCarName;
        private Label label5;
        private RadioButton rbToyota;
        private RadioButton rbNissan;
        private RadioButton rbHonda;
        private RadioButton rbSubaru;
        private RadioButton rbImporter;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private TextBox tbReport;
        private Button btModifyReport;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private Label label6;
        private Button btAddReport;
        private Button btPicOpen;
        private Button btDelete;
        private DataGridView dgvCarReport;
        private Button btReportOpen;
        private Button btReportSave;
        private Label label7;
        private OpenFileDialog ofdPicFileOpen;
        private StatusStrip ssMessageArea;
        private ToolStripStatusLabel tslbMessage;
        private OpenFileDialog ofdReportFileOpen;
        private SaveFileDialog sfdReportFileSave;
    }
}
