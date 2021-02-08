using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Imagedate : Form
    {
        public static OpenFileDialog dialog = new OpenFileDialog();
        public static string[][] array;

        public Imagedate()
        {
            InitializeComponent();
            TimePick.Format = DateTimePickerFormat.Custom;
            TimePick.CustomFormat = "HH:mm";
            TimePick.ShowUpDown = true;
            TimePick.Width = 100;
            Controls.Add(TimePick);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Title = "Open Image";
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(dialog.FileName);
            }

            dialog.Dispose();
        }
        private void Imagedate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            //array=new Array[form1.do][4]
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string yol = "Data source=Insta.db3; Version=3;";
            SQLiteConnection baglanti = new SQLiteConnection(yol);
            try
            {
               
                baglanti.Open();
                string sql = "insert into Images(Location,Date,Time,Comment)values (@Loc,@Date,@Time,@Comment)";
                SQLiteCommand komut = new SQLiteCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@Loc", dialog.FileName);
                komut.Parameters.AddWithValue("@Date", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                komut.Parameters.AddWithValue("@Time", TimePick.Value.ToString("HH:mm"));
                komut.Parameters.AddWithValue("@Comment", textBox2.Text);

                komut.ExecuteNonQuery();

                
            }
            catch (Exception)
            {
                MessageBox.Show("Eksik veya hatalı giriş yaptınız!");
                
            }
            finally
            {
                baglanti.Close();
                pictureBox1.InitialImage = null;
                textBox2.Text = "";
            }

           
            //if (dateTimePicker1.Value.Date.ToString() == DateTime.Now.Date.ToString())
            //{
            //    MessageBox.Show("Saat doğru yaprak");
            //}
        }
        private void Clear()
        {
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz
        }
    }
}
