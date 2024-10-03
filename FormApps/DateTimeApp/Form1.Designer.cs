namespace DateTimeApp {
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
            btDateCount = new Button();
            tbDisp = new TextBox();
            btDayBefore = new Button();
            BtDayafter = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            btAege = new Button();
            nudDay = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(21, 49);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(137, 44);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(198, 39);
            dtpDate.TabIndex = 1;
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(196, 89);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(139, 54);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDateCount_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp.Location = new Point(12, 318);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(446, 43);
            tbDisp.TabIndex = 3;
            // 
            // btDayBefore
            // 
            btDayBefore.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayBefore.Location = new Point(196, 161);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(109, 65);
            btDayBefore.TabIndex = 4;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBufore_Click;
            // 
            // BtDayafter
            // 
            BtDayafter.Font = new Font("メイリオ", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            BtDayafter.Location = new Point(196, 232);
            BtDayafter.Name = "BtDayafter";
            BtDayafter.Size = new Size(109, 65);
            BtDayafter.TabIndex = 5;
            BtDayafter.Text = "日後";
            BtDayafter.UseVisualStyleBackColor = true;
            BtDayafter.Click += BtDayafter_Click;
            // 
            // btAege
            // 
            btAege.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAege.Location = new Point(347, 161);
            btAege.Name = "btAege";
            btAege.Size = new Size(89, 65);
            btAege.TabIndex = 6;
            btAege.Text = "年齢";
            btAege.UseVisualStyleBackColor = true;
            btAege.Click += btAege_Click;
            // 
            // numericUpDown1
            // 
            nudDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(21, 207);
            nudDay.Name = "numericUpDown1";
            nudDay.Size = new Size(148, 39);
            nudDay.TabIndex = 7;
            nudDay.Value = new decimal(new int[] { 66, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 388);
            Controls.Add(nudDay);
            Controls.Add(btAege);
            Controls.Add(BtDayafter);
            Controls.Add(btDayBefore);
            Controls.Add(tbDisp);
            Controls.Add(btDateCount);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Button btDateCount;
        private TextBox tbDisp;
        private Button btDayBefore;
        private Button BtDayafter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button btAege;
        private NumericUpDown nudDay;
    }
}
