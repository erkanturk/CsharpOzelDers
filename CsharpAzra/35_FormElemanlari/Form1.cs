namespace _35_FormElemanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ac_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Title = "Dosya Seç";
            openFileDialog.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Resimler (*.jpg;*.png)|*.jpg;*.png|Tüm Dosyalar (*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;
                MessageBox.Show("Seçilen Dosya:\n" + dosyaYolu);
            }

        }
    }
}
