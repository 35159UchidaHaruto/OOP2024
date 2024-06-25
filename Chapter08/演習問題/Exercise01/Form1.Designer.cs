namespace Exercise01 {
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
            btEx8_1 = new Button();
            tbDisp = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btEx8_1
            // 
            btEx8_1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btEx8_1.Location = new Point(29, 12);
            btEx8_1.Name = "btEx8_1";
            btEx8_1.Size = new Size(134, 51);
            btEx8_1.TabIndex = 0;
            btEx8_1.Text = "問題8.1";
            btEx8_1.UseVisualStyleBackColor = true;
            btEx8_1.Click += btEx8_1_Click;
            // 
            // tbDisp
            // 
            tbDisp.Location = new Point(12, 101);
            tbDisp.Multiline = true;
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(229, 167);
            tbDisp.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(308, 12);
            button1.Name = "button1";
            button1.Size = new Size(134, 51);
            button1.TabIndex = 2;
            button1.Text = "問題8.2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btEx8_2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 167);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += btEx8_2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button2.Location = new Point(580, 12);
            button2.Name = "button2";
            button2.Size = new Size(134, 51);
            button2.TabIndex = 4;
            button2.Text = "問題8.3";
            button2.UseVisualStyleBackColor = true;
            button2.TextChanged += btEx8_3_Click;
            button2.Click += btEx8_3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(529, 101);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 167);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(tbDisp);
            Controls.Add(btEx8_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEx8_1;
        private TextBox tbDisp;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
    }
}
