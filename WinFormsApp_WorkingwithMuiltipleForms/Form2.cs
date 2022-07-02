using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_WorkingwithMuiltipleForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) //form2 yi kapama işlemini dialogresult ile değil de manuel olarak yapma!!
        {
            this.DialogResult = DialogResult.Yes; //this => içinde bulunduğumuz class'ın özelliklerine erişmek için!
            this.Close();
        }
    }
}
