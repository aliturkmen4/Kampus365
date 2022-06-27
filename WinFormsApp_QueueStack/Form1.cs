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

            Queue kuyruk = new Queue(); //ilk giren ilk çýkar!

            kuyruk.Enqueue(10); //içerisine eleman eklemek için enqueue kullanýlýr!
            kuyruk.Enqueue(20);
            kuyruk.Enqueue(30);

            int item = (int)kuyruk.Dequeue(); //listenin üstünden 10 elemanýný alýr ve listeden kaldýrýr!

            int item2 = (int)kuyruk.Peek(); //listenin üstünden eleman alýnýr ama listeden kaldýrýlmaz!!!!

            MessageBox.Show("Kuyruktan Al: " + item); //

            //LIFO-last in first out

            Stack yigin=new Stack();

            yigin.Push(25);
            yigin.Push(35);
            yigin.Push(45);
            yigin.Push(55);

            int item3 = (int)yigin.Pop(); //listenin en sonundaki elemaný alýr ve listeden kaldýrýr!
            
            int item4 = (int)yigin.Peek(); //listenin en sonundaki elemaný alýr ama listeden kaldýrýlmaz!!!!

            MessageBox.Show("Yýðýndan Al: " + item3); //55

        }
    }
}