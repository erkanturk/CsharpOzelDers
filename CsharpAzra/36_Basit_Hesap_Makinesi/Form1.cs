namespace _36_Basit_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        //Kullanıcı login ekranı olacak 
        //Sisteme giriş yapmak için kullanıcı adı ve şifre değerini girecek
        //Var sayılan giriş bilgileri Admin Şifre 1453 olsun
        //eğer kullanıcı doğru girmezse kullanucı adı ve şifreyi 
        //Kullanıcı adı veya şifre hatalı desin
        //Doğru girerse Hoşgeldin Admin
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Islem_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            if (cmbIslem.Text == "+")
            {
                sayi1 = Convert.ToDouble(mTxtSayi1.Text);
                sayi2 = Convert.ToDouble(mTxtSayi2.Text);
                sonuc = sayi1 + sayi2;
                lst_Sonuc.Items.Add(sonuc);
            }
            else if (cmbIslem.Text == "-")
            {
                sayi1 = Convert.ToDouble(mTxtSayi1.Text);
                sayi2 = Convert.ToDouble(mTxtSayi2.Text);
                sonuc = sayi1 - sayi2;
                lst_Sonuc.Items.Add(sonuc);
            }
            else if (cmbIslem.Text == "*")
            {
                sayi1 = Convert.ToDouble(mTxtSayi1.Text);
                sayi2 = Convert.ToDouble(mTxtSayi2.Text);
                sonuc = sayi1 * sayi2;
                lst_Sonuc.Items.Add(sonuc);
            }
            else if (cmbIslem.Text == "/")
            {
                if (mTxtSayi2.Text != "0")
                {
                    sayi1 = Convert.ToDouble(mTxtSayi1.Text);
                    sayi2 = Convert.ToDouble(mTxtSayi2.Text);
                    sonuc = sayi1 / sayi2;
                    lst_Sonuc.Items.Add(sonuc);
                }
                else
                {
                    MessageBox.Show("Sayı sıfıra bölünemez");
                }
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            mTxtSayi1.Clear();
            mTxtSayi2.Clear();
            cmbIslem.SelectedIndex = -1;
            lst_Sonuc.Items.Clear();
        }
    }
}
