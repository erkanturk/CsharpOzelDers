using System.Collections;

namespace _37_ManavOtomasyon
{
    public partial class Form1 : Form
    {
        ArrayList halMeyveler = new ArrayList() { "ELMA", "ARMUT", "MANDALİNA", "PORTAKAL", "KARPUZ", "KAVUN" };
        ArrayList halSebzeler = new ArrayList() { "DOMATES", "BİBER", "PATLICAN", "PATATES", "ISPANAK", "SOĞAN" };
        ArrayList manavMeyveler = new ArrayList();
        ArrayList manavSebzeler = new ArrayList();
        ArrayList manavMeyveKilo = new ArrayList();
        ArrayList manavSebzeKilo = new ArrayList();
        ArrayList musteri = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cmbHalKategori.SelectedIndex != 0)
            {
                cmbHalKategori.SelectedItem = "Meyve";
            }
            GuncelleHalUrunler();
            if (cmbManavKategori.SelectedIndex != 0)
            {
                cmbManavKategori.SelectedItem = "Meyve";
            }
            GuncelleManavUrunler();
            GuncelleMusteri();
        }
        private void GuncelleHalUrunler()
        {
            lstHalUrunler.Items.Clear();
            if (cmbHalKategori.SelectedItem.ToString() == "Meyve")
            {
                foreach (var meyve in halMeyveler)
                {
                    lstHalUrunler.Items.Add(meyve);
                }
            }
            else if (cmbHalKategori.SelectedItem.ToString() == "Sebze")
            {
                foreach (var sebze in halSebzeler)
                {
                    lstHalUrunler.Items.Add(sebze);
                }
            }
            else
            {
                MessageBox.Show("Bir Kategori seçimi yapınız");
            }
        }
        private void GuncelleManavUrunler()
        {
            lstManavUrunler.Items.Clear();
            if (cmbManavKategori.SelectedItem?.ToString() == "Meyve")
            {
                for (int i = 0; i < manavMeyveler.Count; i++)
                {
                    lstManavUrunler.Items.Add($"{manavMeyveler[i]}-{manavMeyveKilo[i]}");
                }
            }
            else
            {
                for (int i = 0; i < manavSebzeler.Count; i++)
                {
                    lstManavUrunler.Items.Add($"{manavSebzeler[i]}-{manavSebzeKilo[i]}");
                }
            }
        }
        private void GuncelleMusteri()
        {
            lstMusteri.Items.Clear();
            foreach (var item in musteri)
            {
                lstMusteri.Items.Add(item.ToString());
            }
        }
        private void UrunAl(ArrayList list, string urun, ArrayList kiloList, int eklenenKilo)
        {
            if (!list.Contains(urun))
            {
                list.Add(urun);
                kiloList.Add(eklenenKilo);
            }
            else
            {
                int index = list.IndexOf(urun);
                int mevcutKilo = (int)kiloList[index];
                kiloList[index] = mevcutKilo + eklenenKilo;
            }
        }

        private void cmbHalKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleHalUrunler();
        }

        private void btnHalEkle_Click(object sender, EventArgs e)
        {
            string kategory = cmbHalKategori.SelectedItem?.ToString();
            string urun = lstHalUrunler.SelectedItem?.ToString();
            if (urun == null)
            {
                MessageBox.Show("Lütfen Bir ürün Seçiniz");
                return;
            }
            if (!int.TryParse(txtHalKilo.Text, out int kilo) || kilo <= 0)
            {
                MessageBox.Show("Geçerli bir kilo giriniz");
                return;
            }
            if (kategory == "Meyve")
            {
                UrunAl(manavMeyveler, urun, manavMeyveKilo, kilo);
                MessageBox.Show($"{urun} {kilo} eklendi");
            }
            else
            {
                UrunAl(manavSebzeler, urun, manavSebzeKilo, kilo);
                MessageBox.Show($"{urun} {kilo} eklendi");
            }
            txtHalKilo.Clear();
            GuncelleManavUrunler();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urun = txtUrun.Text.ToUpper();
            if (cmbHalKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Kategori belirtin");
                return;
            }
            if (cmbHalKategori.SelectedIndex == 0)
            {
                if (!string.IsNullOrWhiteSpace(urun))
                {
                    if (!halMeyveler.Contains(urun))
                    {
                        halMeyveler.Add(urun.ToUpper());
                        lstHalUrunler.Items.Add(urun.ToString().ToUpper());
                        MessageBox.Show($"{urun} hal'e eklendi");
                    }
                    else
                    {
                        MessageBox.Show($"{urun} zaten mevcut");
                    }
                }

            }
            else
            {
                if (!string.IsNullOrWhiteSpace(urun))
                {
                    if (!halSebzeler.Contains(urun))
                    {
                        halSebzeler.Add(urun.ToUpper());
                        lstHalUrunler.Items.Add(urun.ToString().ToUpper());
                        MessageBox.Show($"{urun} hal'e eklendi");
                    }
                    else
                    {
                        MessageBox.Show($"{urun} zaten mevcut");
                    }
                }
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            string kategori = cmbManavKategori.SelectedItem.ToString();
            string secilenUrunFull = lstManavUrunler.SelectedItem?.ToString();
            if (secilenUrunFull == null)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] urunParts = secilenUrunFull.Split('-');
            if (urunParts.Length < 2)
            {
                MessageBox.Show("Geçersiz ürün formatı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string secilenUrun = urunParts[0].Trim();
            if (!int.TryParse(txtManavKilo.Text, out int kilo) || kilo <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir kilo giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool satildi = false;

            if (kategori == "Meyve")
            {
                int index = manavMeyveler.IndexOf(secilenUrun);
                if (index >= 0)
                {
                    int mevcutKilo = (int)manavMeyveKilo[index];
                    if (mevcutKilo >= kilo)
                    {
                        manavMeyveKilo[index] = mevcutKilo - kilo;
                        musteri.Add($"{secilenUrun} - {kilo} kg");
                        if ((int)manavMeyveKilo[index] == 0)
                        {
                            manavMeyveler.RemoveAt(index);
                            manavMeyveKilo.RemoveAt(index);
                        }
                        satildi = true;
                        MessageBox.Show("Satış başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Yeterli stok yok. Mevcut: {mevcutKilo} kg", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                int index = manavSebzeler.IndexOf(secilenUrun);
                if (index >= 0)
                {
                    int mevcutKilo = (int)manavSebzeKilo[index];
                    if (mevcutKilo >= kilo)
                    {
                        manavSebzeKilo[index] = mevcutKilo - kilo;
                        musteri.Add($"{secilenUrun} - {kilo} kg");
                        if ((int)manavSebzeKilo[index] == 0)
                        {
                            manavSebzeler.RemoveAt(index);
                            manavSebzeKilo.RemoveAt(index);
                        }
                        satildi = true;
                        MessageBox.Show("Satış başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Yeterli stok yok. Mevcut: {mevcutKilo} kg", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            if (satildi)
            {
                GuncelleManavUrunler();
                GuncelleMusteri();

            }

            txtManavKilo.Clear();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmbManavKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            GuncelleManavUrunler();
        }
    }

}
