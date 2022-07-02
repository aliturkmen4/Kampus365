namespace WinFormsApp_MessageBoxWindowDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu bir mesaj metnidir", "Bu bir ba�l�kt�r!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); //text, caption, buton ve icon verdim verdim!

            //MessageBoxDefaultButton.Button1 diyerek yesnocancel dan yes'i daha belirgin hale getirmi� oldum!

            //MessageBox bize DialogResult t�r�nde bir enum d�nd�r�r!

            if(result== DialogResult.Yes)
            {
                MessageBox.Show("Yes t�kland�!");
            }
            else if(result== DialogResult.No)
            {
                MessageBox.Show("No t�kland�!");
            }
            else
            {
                MessageBox.Show("Cancel t�kland�!");
            }
        }
    }
}