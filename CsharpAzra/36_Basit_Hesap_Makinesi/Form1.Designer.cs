namespace _36_Basit_Hesap_Makinesi
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            mTxtSayi1 = new MaskedTextBox();
            mTxtSayi2 = new MaskedTextBox();
            cmbIslem = new ComboBox();
            label3 = new Label();
            btn_Islem = new Button();
            btn_Sil = new Button();
            lst_Sonuc = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lst_Sonuc);
            groupBox1.Controls.Add(btn_Sil);
            groupBox1.Controls.Add(btn_Islem);
            groupBox1.Controls.Add(cmbIslem);
            groupBox1.Controls.Add(mTxtSayi2);
            groupBox1.Controls.Add(mTxtSayi1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(0, -2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 453);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 0;
            label1.Text = "1.Sayi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 1;
            label2.Text = "2.Sayı";
            // 
            // mTxtSayi1
            // 
            mTxtSayi1.Location = new Point(125, 19);
            mTxtSayi1.Mask = "00000000000";
            mTxtSayi1.Name = "mTxtSayi1";
            mTxtSayi1.Size = new Size(100, 26);
            mTxtSayi1.TabIndex = 2;
            mTxtSayi1.ValidatingType = typeof(int);
            // 
            // mTxtSayi2
            // 
            mTxtSayi2.Location = new Point(125, 69);
            mTxtSayi2.Mask = "00000000000";
            mTxtSayi2.Name = "mTxtSayi2";
            mTxtSayi2.Size = new Size(100, 26);
            mTxtSayi2.TabIndex = 2;
            mTxtSayi2.ValidatingType = typeof(int);
            // 
            // cmbIslem
            // 
            cmbIslem.FormattingEnabled = true;
            cmbIslem.Items.AddRange(new object[] { "+", "*", "-", "/" });
            cmbIslem.Location = new Point(125, 124);
            cmbIslem.Name = "cmbIslem";
            cmbIslem.Size = new Size(100, 27);
            cmbIslem.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 132);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 1;
            label3.Text = "İşlem";
            // 
            // btn_Islem
            // 
            btn_Islem.Location = new Point(125, 217);
            btn_Islem.Name = "btn_Islem";
            btn_Islem.Size = new Size(87, 31);
            btn_Islem.TabIndex = 4;
            btn_Islem.Text = "İşlem Yap";
            btn_Islem.UseVisualStyleBackColor = true;
            btn_Islem.Click += btn_Islem_Click;
            // 
            // btn_Sil
            // 
            btn_Sil.Location = new Point(125, 264);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(87, 34);
            btn_Sil.TabIndex = 5;
            btn_Sil.Text = "Temizle";
            btn_Sil.UseVisualStyleBackColor = true;
            btn_Sil.Click += btn_Sil_Click;
            // 
            // lst_Sonuc
            // 
            lst_Sonuc.FormattingEnabled = true;
            lst_Sonuc.Location = new Point(260, 16);
            lst_Sonuc.Name = "lst_Sonuc";
            lst_Sonuc.Size = new Size(120, 137);
            lst_Sonuc.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Sil;
        private Button btn_Islem;
        private ComboBox cmbIslem;
        private MaskedTextBox mTxtSayi2;
        private MaskedTextBox mTxtSayi1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lst_Sonuc;
    }
}
