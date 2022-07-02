namespace WinFormsApp_WorkingwithMuiltipleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            //frm.Show(); //form2 yi açar, form1 e de geçmene izin verir(iki formu da ayný anda kullanmaya olanak saðlar)!
           DialogResult result=frm.ShowDialog(); //form2 kapanmadan form1 e geri dönmeyi engeller!

            //form2 içindeki butonlara propertylerden dialogresult atayýnca kapatmasý gerektiðini kendi içinde belirler ve formu kapatýr!

            if (result == DialogResult.OK)
            {
                //.....
            }

            MessageBox.Show(result.ToString());
        }
    }
}