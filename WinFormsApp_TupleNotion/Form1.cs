namespace WinFormsApp_TupleNotion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tuple<int, string, bool> item = new Tuple<int, string, bool>(10, "Ali", true);

            //MessageBox.Show("item 1: " + item.Item1);
            //MessageBox.Show("item 2: " + item.Item2);
            //MessageBox.Show("item 3: " + item.Item3);

            List<Tuple<int,string,bool>> list = new List<Tuple<int,string,bool>>(); //elimde her sat�rda 3 eleman alan bir liste olacak!

            list.Add(new Tuple<int, string, bool>(18, "Ali", false));
            list.Add(new Tuple<int, string, bool>(25, "Resul", true));

            foreach (Tuple<int,string,bool> itm in list)
            {
                MessageBox.Show($"item 1: {itm.Item1} - item 2: {itm.Item2} - item 3: {itm.Item3}"); //string interpolation
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Tuple<int, string, bool> item2 = new Tuple<int, string, bool>(10, "Ali", true); 
            (int Adet, string Adi, bool StoktaMi) item = (15, "Ali", false); //tuple iyile�tirilmi� hali
            item.Adet = 25; //klasik tuple class� readonly oldu�u i�in bize bu imkan� sa�lamaz!

           Tuple<int,string,bool> item2=item.ToTuple(); //iyile�tirilmi� tuple'� klasik tuple a �evirme!

            //item2.Item1 = 20; //sadece readonly oldu�u i�in burada de�er atamama izin vermez!
        }
    }
}