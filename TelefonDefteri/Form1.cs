namespace TelefonDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            string name = txtAd.Text;
            string lastName = txtSoyad.Text;
            string phone = mtxtTelefon.Text;
            string mail = txtEposta.Text;
            string group = cmbGrup.Text;
            string description = txtAciklama.Text;

            string entry = $"{name} {lastName} {phone} {mail} {description} {group}";
            lstKisiler.Items.Add(entry);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedIndex > -1)
            {
                int index = lstKisiler.SelectedIndex; //seçili olan satýrýn index numarasýný verir!
                lstKisiler.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Lütfen bir kayýt seçiniz!", "Seçim yapmadýnýz!", MessageBoxButtons.OK, MessageBoxIcon.Warning); //alert kutusunun içini düzenledim!
            }

        }
    }
}