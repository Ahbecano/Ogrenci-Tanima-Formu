namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAdSoyad = new TextBox();
            txtOkulNo = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            txtSınıf = new TextBox();
            btnTemizle = new Button();
            lstGöster = new ListBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 30);
            label1.Name = "label1";
            label1.Size = new Size(362, 41);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ KAYIT FORMU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 139);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 209);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Okul No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 276);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 139);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyet :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 209);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 5;
            label6.Text = "Sınıf :";
    
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 276);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 6;
            label7.Text = "Bölüm :";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(168, 136);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 1;
            txtAdSoyad.TextChanged += maskedTextBox1.TextChanged;
            // 
            // txtOkulNo
            // 
            txtOkulNo.Location = new Point(168, 206);
            txtOkulNo.Name = "txtOkulNo";
            txtOkulNo.Size = new Size(125, 27);
            txtOkulNo.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(168, 273);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Erkek", "Kız" });
            comboBox1.Location = new Point(507, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "İnternet Ağ ve Teknolojileri", "Dış Ticaret", "Otomasyon", "Ormancılık", "Çocuk Gelişim", "Lojistik" });
            comboBox2.Location = new Point(508, 273);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 6;
            // 
            // txtSınıf
            // 
            txtSınıf.Location = new Point(507, 206);
            txtSınıf.Name = "txtSınıf";
            txtSınıf.Size = new Size(125, 27);
            txtSınıf.TabIndex = 5;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(168, 345);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(125, 53);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lstGöster
            // 
            lstGöster.FormattingEnabled = true;
            lstGöster.Location = new Point(12, 437);
            lstGöster.Name = "lstGöster";
            lstGöster.Size = new Size(658, 104);
            lstGöster.TabIndex = 11;
            lstGöster.TabStop = false;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(507, 345);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(125, 53);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(682, 553);
            Controls.Add(lstGöster);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtSınıf);
            Controls.Add(txtOkulNo);
            Controls.Add(txtAdSoyad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Kayıt Formu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAdSoyad;
        private TextBox txtOkulNo;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox txtSınıf;
        private Button btnTemizle;
        private ListBox lstGöster;
        private Button btnKaydet;
    }
  }

