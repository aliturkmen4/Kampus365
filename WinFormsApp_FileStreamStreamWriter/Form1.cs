namespace WinFormsApp_FileStreamStreamWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            string metin = txtNot.Text;
            lstNotlar.Items.Add(metin);
        }

        private void btnDosyayaKaydet_Click(object sender, EventArgs e)
        {
            //string masaustu=Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\dosya.txt"; //masa�st� path ini otomatik ald�m ve dosya.txt ye yazd�m!!
            string path = Application.StartupPath + "\\dosya.txt"; //exe nin �al��t� konuma txt olu�turup filestream de onu vermek daha sa�l�kl�! open in file explorer diyerek klas�r�n konumuna git orada bin klas�r� i�inde dosya.txt olu�turur!
            FileStream stream = new FileStream(path, FileMode.Create);
            //createnew dersem 2. kez ayn� dosyaya yazarken hata al�r�m fakat create dersem ilkini ezer ve �st�ne yazar!!!
            StreamWriter streamWriter = new StreamWriter(stream);
            foreach (string item in lstNotlar.Items)
            {
                streamWriter.WriteLine(item);
            }
            streamWriter.Close(); //yazma i�lemini bitirmek i�in!
            stream.Close();

            MessageBox.Show("Dosyaya Kaydedildi!","��lem Tamamland�!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}