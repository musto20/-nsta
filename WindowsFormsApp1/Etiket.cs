using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Etiket : Form
    {
        public mailLogin log2 = new mailLogin();
        private Form1 Form1Instance
        {
            get;
            set;
        }
        public Etiket()
        {
            
            InitializeComponent();
        }
        public Etiket(Form1 form1Instance)
        {
            Form1Instance = form1Instance;
        }
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string[] value2 = listBox1.Items[0].ToString().Split(':');
        //    log2.search(value2[0],Convert.ToInt32(value2[1]));
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

//}

//private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
//{
//    
//}

//private void textBox3_KeyDown(object sender, KeyEventArgs e)
//{
//   

//}

//private void button3_Click(object sender, EventArgs e)
//{
//    Form1 fm = new Form1();
//    fm.Show();
//    this.Close();
//}

private void Etiket_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
