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
            openFileDialog.Title = "Özel Bir Dosya Seç";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); //baþlangýçta nereyi açsýn?(path girmeni bekler) getfolderpath path'i otomatik bulup string olarak bana getirir!
            openFileDialog.Multiselect = false; //çoklu seçim için!
            openFileDialog.RestoreDirectory = true; //mypicture konumunda açtýðým directory i kullanýcý daha sonra desktop'a giderse desktop konumunu hatýrlamasý için kullanýlýr!
            openFileDialog.Filter = "BMP Files(*.bmp)|*.bmp|PNG Files(*.png)|*.png|All JPEG Files(*.jpg;*.jpeg)|*.jpg;*.jpeg|All Files(*.*)|*.*"; //ekranda hangi dosya uzantýlarýný göstereceðini seçmemize yarar!
            DialogResult result= openFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                string filePath=openFileDialog.FileName; //seçtiðim dosyanýn tam uzantýsýný verir!  (C:\users\ali\desktop\abc.jpg)
            }
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Özel Bir Dosya Seç";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); 
            saveFileDialog.RestoreDirectory = true; 
            saveFileDialog.OverwritePrompt= true; //bir dosyanýn üzerine yazarken kullanýcýdan onay alýnsýn mý diye sorar!
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
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyPictures; //otomatik olarak þu path'i aç!
            folderBrowserDialog.ShowNewFolderButton = true; //kullanýcý yeni klasör oluþturabilsin mi ?
            folderBrowserDialog.Description = "Bu bir açýklama metnidir!";
            folderBrowserDialog.UseDescriptionForTitle = false; //description baþlýk olarak kullanýlsýn mý?

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