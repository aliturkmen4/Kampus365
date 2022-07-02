namespace WinFormsApp_RecognizeDialogWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "�zel Bir Dosya Se�";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); //ba�lang��ta nereyi a�s�n?(path girmeni bekler) getfolderpath path'i otomatik bulup string olarak bana getirir!
            openFileDialog.Multiselect = false; //�oklu se�im i�in!
            openFileDialog.RestoreDirectory = true; //mypicture konumunda a�t���m directory i kullan�c� daha sonra desktop'a giderse desktop konumunu hat�rlamas� i�in kullan�l�r!
            openFileDialog.Filter = "BMP Files(*.bmp)|*.bmp|PNG Files(*.png)|*.png|All JPEG Files(*.jpg;*.jpeg)|*.jpg;*.jpeg|All Files(*.*)|*.*"; //ekranda hangi dosya uzant�lar�n� g�sterece�ini se�memize yarar!
            DialogResult result= openFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                string filePath=openFileDialog.FileName; //se�ti�im dosyan�n tam uzant�s�n� verir!  (C:\users\ali\desktop\abc.jpg)
            }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "�zel Bir Dosya Se�";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); 
            saveFileDialog.RestoreDirectory = true; 
            saveFileDialog.OverwritePrompt= true; //bir dosyan�n �zerine yazarken kullan�c�dan onay al�ns�n m� diye sorar!
            saveFileDialog.Filter = "TXT Files(*.txt)|*.txt|PNG Files(*.png)|*.png|All JPEG Files(*.jpg;*.jpeg)|*.jpg;*.jpeg|All Files(*.*)|*.*"; 
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                MessageBox.Show(filePath);
            }
        }

        private void btnFolderDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //folderBrowserDialog.SelectedPath= Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyPictures; //otomatik olarak �u path'i a�!
            folderBrowserDialog.ShowNewFolderButton = true; //kullan�c� yeni klas�r olu�turabilsin mi ?
            folderBrowserDialog.Description = "Bu bir a��klama metnidir!";
            folderBrowserDialog.UseDescriptionForTitle = false; //description ba�l�k olarak kullan�ls�n m�?

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                MessageBox.Show(selectedPath);
            }
        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
           DialogResult dialog=  printDialog.ShowDialog();
            if (dialog == DialogResult.OK)
            {
              //print...
            }
        }
    }
}