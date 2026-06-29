namespace _37_ManavOtomasyon
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEkle = new Button();
            btnHalEkle = new Button();
            txtHalKilo = new TextBox();
            txtUrun = new TextBox();
            lstHalUrunler = new ListBox();
            cmbHalKategori = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            lstMusteri = new ListBox();
            lstManavUrunler = new ListBox();
            btnSatisYap = new Button();
            txtManavKilo = new TextBox();
            cmbManavKategori = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnCikis = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabControl1.Location = new Point(3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 439);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEkle);
            tabPage1.Controls.Add(btnHalEkle);
            tabPage1.Controls.Add(txtHalKilo);
            tabPage1.Controls.Add(txtUrun);
            tabPage1.Controls.Add(lstHalUrunler);
            tabPage1.Controls.Add(cmbHalKategori);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hal Toptancı";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(150, 350);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(81, 29);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Hal Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnHalEkle
            // 
            btnHalEkle.Location = new Point(17, 350);
            btnHalEkle.Name = "btnHalEkle";
            btnHalEkle.Size = new Size(81, 29);
            btnHalEkle.TabIndex = 5;
            btnHalEkle.Text = "Manav Ekle";
            btnHalEkle.UseVisualStyleBackColor = true;
            btnHalEkle.Click += btnHalEkle_Click;
            // 
            // txtHalKilo
            // 
            txtHalKilo.Location = new Point(150, 294);
            txtHalKilo.Name = "txtHalKilo";
            txtHalKilo.Size = new Size(100, 29);
            txtHalKilo.TabIndex = 4;
            // 
            // txtUrun
            // 
            txtUrun.Location = new Point(10, 294);
            txtUrun.Name = "txtUrun";
            txtUrun.Size = new Size(100, 29);
            txtUrun.TabIndex = 3;
            // 
            // lstHalUrunler
            // 
            lstHalUrunler.FormattingEnabled = true;
            lstHalUrunler.Location = new Point(18, 58);
            lstHalUrunler.Name = "lstHalUrunler";
            lstHalUrunler.Size = new Size(232, 193);
            lstHalUrunler.TabIndex = 2;
            // 
            // cmbHalKategori
            // 
            cmbHalKategori.FormattingEnabled = true;
            cmbHalKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbHalKategori.Location = new Point(104, 14);
            cmbHalKategori.Name = "cmbHalKategori";
            cmbHalKategori.Size = new Size(121, 29);
            cmbHalKategori.TabIndex = 1;
            cmbHalKategori.SelectedIndexChanged += cmbHalKategori_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 264);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 0;
            label3.Text = "Kilo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 264);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 0;
            label2.Text = "Ürün";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Kategori";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstMusteri);
            tabPage2.Controls.Add(lstManavUrunler);
            tabPage2.Controls.Add(btnSatisYap);
            tabPage2.Controls.Add(txtManavKilo);
            tabPage2.Controls.Add(cmbManavKategori);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manav";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstMusteri
            // 
            lstMusteri.FormattingEnabled = true;
            lstMusteri.Location = new Point(517, 80);
            lstMusteri.Name = "lstMusteri";
            lstMusteri.Size = new Size(269, 151);
            lstMusteri.TabIndex = 6;
            // 
            // lstManavUrunler
            // 
            lstManavUrunler.FormattingEnabled = true;
            lstManavUrunler.Location = new Point(3, 80);
            lstManavUrunler.Name = "lstManavUrunler";
            lstManavUrunler.Size = new Size(238, 151);
            lstManavUrunler.TabIndex = 6;
            // 
            // btnSatisYap
            // 
            btnSatisYap.Location = new Point(84, 343);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(119, 30);
            btnSatisYap.TabIndex = 5;
            btnSatisYap.Text = "Satış Yap";
            btnSatisYap.UseVisualStyleBackColor = true;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // txtManavKilo
            // 
            txtManavKilo.Location = new Point(84, 280);
            txtManavKilo.Name = "txtManavKilo";
            txtManavKilo.Size = new Size(144, 29);
            txtManavKilo.TabIndex = 4;
            // 
            // cmbManavKategori
            // 
            cmbManavKategori.FormattingEnabled = true;
            cmbManavKategori.Items.AddRange(new object[] { "Meyve", "Sebze" });
            cmbManavKategori.Location = new Point(107, 14);
            cmbManavKategori.Name = "cmbManavKategori";
            cmbManavKategori.Size = new Size(121, 29);
            cmbManavKategori.TabIndex = 3;
            cmbManavKategori.SelectedIndexChanged += cmbManavKategori_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 288);
            label5.Name = "label5";
            label5.Size = new Size(36, 21);
            label5.TabIndex = 2;
            label5.Text = "Kilo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(517, 22);
            label6.Name = "label6";
            label6.Size = new Size(186, 21);
            label6.TabIndex = 2;
            label6.Text = "Müşterinin Aldığı Ürünler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 17);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 2;
            label4.Text = "Kategori";
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(713, 457);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(75, 23);
            btnCikis.TabIndex = 1;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(btnCikis);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Manav Otomasyon";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtHalKilo;
        private TextBox txtUrun;
        private ListBox lstHalUrunler;
        private ComboBox cmbHalKategori;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button btnEkle;
        private Button btnHalEkle;
        private ComboBox cmbManavKategori;
        private Label label5;
        private Label label4;
        private Button btnCikis;
        private ListBox lstMusteri;
        private ListBox lstManavUrunler;
        private Button btnSatisYap;
        private TextBox txtManavKilo;
        private Label label6;
    }
}
