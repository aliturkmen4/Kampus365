namespace WinFormsApp_DataSharingBetweenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn�slemYap_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Ad = txtAd.Text;
            frm.Soyad = txtSoyad.Text;
            frm.ShowDialog();
            lblSonuc.Text = frm.AdSoyad; //form2 de elde etti�im ad soyad properysini lblsonuc'un textine att�m!
            lblSonuc.Visible = true; //visible � false olan lable � i�erisine de�er atad�ktan sonra true yapt�m!
        }
    }
}