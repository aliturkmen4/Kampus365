namespace WinFormsApp_MDIForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formOlu�turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form= new Form();
            form.Text="Form - "+(this.MdiChildren.Length+1); //olu�acak yeni forma olu�ma s�ras�na g�re isim verdim!
            form.MdiParent = this; //senin parent formun form1 dir dedim!
            form.Show(); //md� formun i�inde showdialog yap�lamaz!         
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons); //ikonlar� s�ralamada kullan�l�r!
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade); //pencereleri merdiven g�r�n�m�nde �apraz s�ralar!
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal); //yatay hizalama
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical); //dikey hizalama
        }

        private void adetFormOlu�turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Form form = new Form();
                form.Text = "Form - " + (this.MdiChildren.Length + 1); 
                form.MdiParent = this; 
                form.Show();  
            }
        }
    }
}