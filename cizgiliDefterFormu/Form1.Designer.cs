namespace cizgiliDefterFormu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yazdirBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.griButton = new System.Windows.Forms.RadioButton();
            this.kirmiziButton = new System.Windows.Forms.RadioButton();
            this.lacivertButton = new System.Windows.Forms.RadioButton();
            this.siyahButton = new System.Windows.Forms.RadioButton();
            this.sariButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xDikdörtgenSayisiTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.yDikdörtgenSayisiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xBaslangicTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yBaslangicTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // yazdirBtn
            // 
            this.yazdirBtn.Location = new System.Drawing.Point(165, 184);
            this.yazdirBtn.Name = "yazdirBtn";
            this.yazdirBtn.Size = new System.Drawing.Size(228, 36);
            this.yazdirBtn.TabIndex = 0;
            this.yazdirBtn.Text = "Ön İzleme";
            this.yazdirBtn.UseVisualStyleBackColor = true;
            this.yazdirBtn.Click += new System.EventHandler(this.yazdirBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sariButton);
            this.groupBox1.Controls.Add(this.griButton);
            this.groupBox1.Controls.Add(this.lacivertButton);
            this.groupBox1.Controls.Add(this.kirmiziButton);
            this.groupBox1.Controls.Add(this.siyahButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çizgi Rengi";
            // 
            // griButton
            // 
            this.griButton.AutoSize = true;
            this.griButton.Checked = true;
            this.griButton.Location = new System.Drawing.Point(10, 31);
            this.griButton.Name = "griButton";
            this.griButton.Size = new System.Drawing.Size(38, 17);
            this.griButton.TabIndex = 4;
            this.griButton.TabStop = true;
            this.griButton.Text = "Gri";
            this.griButton.UseVisualStyleBackColor = true;
            // 
            // kirmiziButton
            // 
            this.kirmiziButton.AutoSize = true;
            this.kirmiziButton.Location = new System.Drawing.Point(10, 54);
            this.kirmiziButton.Name = "kirmiziButton";
            this.kirmiziButton.Size = new System.Drawing.Size(54, 17);
            this.kirmiziButton.TabIndex = 5;
            this.kirmiziButton.Text = "Kırmızı";
            this.kirmiziButton.UseVisualStyleBackColor = true;
            // 
            // lacivertButton
            // 
            this.lacivertButton.AutoSize = true;
            this.lacivertButton.Location = new System.Drawing.Point(10, 100);
            this.lacivertButton.Name = "lacivertButton";
            this.lacivertButton.Size = new System.Drawing.Size(63, 17);
            this.lacivertButton.TabIndex = 7;
            this.lacivertButton.Text = "Lacivert";
            this.lacivertButton.UseVisualStyleBackColor = true;
            // 
            // siyahButton
            // 
            this.siyahButton.AutoSize = true;
            this.siyahButton.Location = new System.Drawing.Point(10, 77);
            this.siyahButton.Name = "siyahButton";
            this.siyahButton.Size = new System.Drawing.Size(51, 17);
            this.siyahButton.TabIndex = 6;
            this.siyahButton.Text = "Siyah";
            this.siyahButton.UseVisualStyleBackColor = true;
            // 
            // sariButton
            // 
            this.sariButton.AutoSize = true;
            this.sariButton.Location = new System.Drawing.Point(10, 123);
            this.sariButton.Name = "sariButton";
            this.sariButton.Size = new System.Drawing.Size(43, 17);
            this.sariButton.TabIndex = 8;
            this.sariButton.Text = "Sarı";
            this.sariButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xBaslangicTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.xDikdörtgenSayisiTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(106, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 156);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "X Dikdörtgen";
            // 
            // xDikdörtgenSayisiTxt
            // 
            this.xDikdörtgenSayisiTxt.Location = new System.Drawing.Point(143, 33);
            this.xDikdörtgenSayisiTxt.Name = "xDikdörtgenSayisiTxt";
            this.xDikdörtgenSayisiTxt.Size = new System.Drawing.Size(62, 20);
            this.xDikdörtgenSayisiTxt.TabIndex = 5;
            this.xDikdörtgenSayisiTxt.Text = "59";
            this.xDikdörtgenSayisiTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dikdörtgen Sayısı ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.yBaslangicTxt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.yDikdörtgenSayisiTxt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(335, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 156);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Y Dikdörtgen";
            // 
            // yDikdörtgenSayisiTxt
            // 
            this.yDikdörtgenSayisiTxt.Location = new System.Drawing.Point(143, 33);
            this.yDikdörtgenSayisiTxt.Name = "yDikdörtgenSayisiTxt";
            this.yDikdörtgenSayisiTxt.Size = new System.Drawing.Size(62, 20);
            this.yDikdörtgenSayisiTxt.TabIndex = 5;
            this.yDikdörtgenSayisiTxt.Text = "43";
            this.yDikdörtgenSayisiTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dikdörtgen Sayısı ";
            // 
            // xBaslangicTxt
            // 
            this.xBaslangicTxt.Location = new System.Drawing.Point(143, 59);
            this.xBaslangicTxt.Name = "xBaslangicTxt";
            this.xBaslangicTxt.Size = new System.Drawing.Size(62, 20);
            this.xBaslangicTxt.TabIndex = 7;
            this.xBaslangicTxt.Text = "5";
            this.xBaslangicTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Başlangıç";
            // 
            // yBaslangicTxt
            // 
            this.yBaslangicTxt.Location = new System.Drawing.Point(143, 59);
            this.yBaslangicTxt.Name = "yBaslangicTxt";
            this.yBaslangicTxt.Size = new System.Drawing.Size(62, 20);
            this.yBaslangicTxt.TabIndex = 9;
            this.yBaslangicTxt.Text = "20";
            this.yBaslangicTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Başlangıç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 247);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.yazdirBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çizgili Defter Form Örneği";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yazdirBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton griButton;
        private System.Windows.Forms.RadioButton kirmiziButton;
        private System.Windows.Forms.RadioButton lacivertButton;
        private System.Windows.Forms.RadioButton siyahButton;
        private System.Windows.Forms.RadioButton sariButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox xDikdörtgenSayisiTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox yDikdörtgenSayisiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xBaslangicTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yBaslangicTxt;
        private System.Windows.Forms.Label label4;
    }
}

