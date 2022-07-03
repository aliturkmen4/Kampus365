namespace WinFormsApp_MDIForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form= new Form();
            form.Text="Form - "+(this.MdiChildren.Length+1); //oluþacak yeni forma oluþma sýrasýna göre isim verdim!
            form.MdiParent = this; //senin parent formun form1 dir dedim!
            form.Show(); //mdý formun içinde showdialog yapýlamaz!         
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons); //ikonlarý sýralamada kullanýlýr!
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade); //pencereleri merdiven görünümünde çapraz sýralar!
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal); //yatay hizalama
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical); //dikey hizalama
        }

        private void adetFormOluþturToolStripMenuItem_Click(object sender, EventArgs e)
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