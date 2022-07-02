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
            DialogResult result = MessageBox.Show("Bu bir mesaj metnidir", "Bu bir baþlýktýr!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); //text, caption, buton ve icon verdim verdim!

            //MessageBoxDefaultButton.Button1 diyerek yesnocancel dan yes'i daha belirgin hale getirmiþ oldum!

            //MessageBox bize DialogResult türünde bir enum döndürür!

            if(result== DialogResult.Yes)
            {
                MessageBox.Show("Yes týklandý!");
            }
            else if(result== DialogResult.No)
            {
                MessageBox.Show("No týklandý!");
            }
            else
            {
                MessageBox.Show("Cancel týklandý!");
            }
        }
    }
}