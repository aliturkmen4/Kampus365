using System.Collections;

namespace WinFormsApp_QueueStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FIFO-first in first out

            Queue kuyruk = new Queue(); //ilk giren ilk ��kar!

            kuyruk.Enqueue(10); //i�erisine eleman eklemek i�in enqueue kullan�l�r!
            kuyruk.Enqueue(20);
            kuyruk.Enqueue(30);

            int item = (int)kuyruk.Dequeue(); //listenin �st�nden 10 eleman�n� al�r ve listeden kald�r�r!

            int item2 = (int)kuyruk.Peek(); //listenin �st�nden eleman al�n�r ama listeden kald�r�lmaz!!!!

            MessageBox.Show("Kuyruktan Al: " + item); //

            //LIFO-last in first out

            Stack yigin=new Stack();

            yigin.Push(25);
            yigin.Push(35);
            yigin.Push(45);
            yigin.Push(55);

            int item3 = (int)yigin.Pop(); //listenin en sonundaki eleman� al�r ve listeden kald�r�r!
            
            int item4 = (int)yigin.Peek(); //listenin en sonundaki eleman� al�r ama listeden kald�r�lmaz!!!!

            MessageBox.Show("Y���ndan Al: " + item3); //55

        }
    }
}