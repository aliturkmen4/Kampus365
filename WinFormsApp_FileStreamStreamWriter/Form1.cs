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
            //string masaustu=Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\dosya.txt"; //masaüstü path ini otomatik aldým ve dosya.txt ye yazdým!!
            string path = Application.StartupPath + "\\dosya.txt"; //exe nin çalýþtý konuma txt oluþturup filestream de onu vermek daha saðlýklý! open in file explorer diyerek klasörün konumuna git orada bin klasörü içinde dosya.txt oluþturur!
            FileStream stream = new FileStream(path, FileMode.Create);
            //createnew dersem 2. kez ayný dosyaya yazarken hata alýrým fakat create dersem ilkini ezer ve üstüne yazar!!!
            StreamWriter streamWriter = new StreamWriter(stream);
            foreach (string item in lstNotlar.Items)
            {
                streamWriter.WriteLine(item);
            }
            streamWriter.Close(); //yazma iþlemini bitirmek için!
            stream.Close();

            MessageBox.Show("Dosyaya Kaydedildi!","Ýþlem Tamamlandý!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}