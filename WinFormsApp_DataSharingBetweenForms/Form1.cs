namespace WinFormsApp_DataSharingBetweenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnÝslemYap_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Ad = txtAd.Text;
            frm.Soyad = txtSoyad.Text;
            frm.ShowDialog();
            lblSonuc.Text = frm.AdSoyad; //form2 de elde ettiðim ad soyad properysini lblsonuc'un textine attým!
            lblSonuc.Visible = true; //visible ý false olan lable ý içerisine deðer atadýktan sonra true yaptým!
        }
    }
}