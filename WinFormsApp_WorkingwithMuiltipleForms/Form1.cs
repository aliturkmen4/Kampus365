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
            //frm.Show(); //form2 yi a�ar, form1 e de ge�mene izin verir(iki formu da ayn� anda kullanmaya olanak sa�lar)!
           DialogResult result=frm.ShowDialog(); //form2 kapanmadan form1 e geri d�nmeyi engeller!

            //form2 i�indeki butonlara propertylerden dialogresult atay�nca kapatmas� gerekti�ini kendi i�inde belirler ve formu kapat�r!

            if (result == DialogResult.OK)
            {
                //.....
            }

            MessageBox.Show(result.ToString());
        }
    }
}