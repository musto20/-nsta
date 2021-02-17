﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assert = NUnit.Framework.Assert;
using NUnit.Framework;
using System.Threading;
using AutoIt;
using AutoItX3Lib;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public mailLogin log = new mailLogin();
        
        public string KlasorYolu;
        public int sayac = 0,sayac2=0,control=1,takipci=0,tsayac=0;
        string[,] x=new string[10,2];
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
                control=log.mailLog(NicknameTBox.Text, SifreTBox.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (control == 0)
            {
                if (sayac2 % 2 == 0)
                {
                    button5.BackColor = Color.Green;
                    timer1.Start();
                    sayac2++;
                }
                else
                {
                    button5.BackColor = Color.Red;
                    timer1.Stop();
                    sayac2++;
                }
            }
            else
                MessageBox.Show("Login işlemini öncelikle yapın!!");            //timer1_Tick();

            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Imagedate form2 = new Imagedate();
            form2.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz
        }

        private void button3_Click(object sender, EventArgs e)
        {
            log.FaceLog("m.zeycan20@hotmail.com","mzeycan2035");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = 10;
            while (i>0)
            {
                i--;
                if (i==0)
                {
                    listBox1.Items.RemoveAt(0);
                }
            } 
            //if (Takipci_SayisiTB.Text=="")
            //{
            //    MessageBox.Show("Takip edilecek kişi sayısı boş bırakılamaz...");
            //}
            //else
            //{
            //    log.Follow(Convert.ToInt32(Takipci_SayisiTB.Text));
            //}
            
        }


        private void Takipci_SayisiTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.driver.Quit();
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            string[] value2 = listBox1.Items[0].ToString().Split(':');
            try
            {
                int a = 0;
                Boolean gelen;
                if (checkBox1.Checked == true || textBox1.Text != "" || textBox2.Text != "") //Eğer checkbox seçiliyse
                {

                    int tekrar = Convert.ToInt32(textBox1.Text);
                    int bekleme = Convert.ToInt32(textBox2.Text);
                    gelen = log.KontrolluFollow(value2[0], Convert.ToInt32(value2[1]), Convert.ToInt32(numeric1.Value), Convert.ToInt32(numeric2.Value), tekrar, bekleme);
                    if (gelen == true)
                    {
                        listBox1.Items.RemoveAt(0);
                    }
                    else
                    {
                        MessageBox.Show("Ekleme sırasında hata oldu");
                    }
                }
                else if (checkBox1.Checked == false)
                {
                    gelen = log.KontrolluFollow(value2[0], Convert.ToInt32(value2[1]), Convert.ToInt32(numeric1.Value), Convert.ToInt32(numeric2.Value), Convert.ToInt32(value2[1]), a);
                    if (gelen == true)
                    {
                        listBox1.Items.RemoveAt(0);
                    }
                    else
                    {
                        MessageBox.Show("Ekleme sırasında hata oldu");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            


        }

        private void button9_Click(object sender, EventArgs e)
        {
            //control = log.mailLog2(NicknameTBox.Text, SifreTBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void KontrolluTakip_Click(object sender, EventArgs e)
        {
            if ("10"==listBox1.Items.Count.ToString())
            {
                MessageBox.Show("10 kayıttan fazlası yapılamaz");
            }
            else
            {
                listBox1.Items.Add(string.Format("{0}:{1}", HesapTB.Text, Takipci_SayisiTB.Text));
            }
        }

        private void Takipci_SayisiTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Kontrol etkinlikleri burada sınırlandırılmıştır");
            }

        }

        private void MyMethod()
        {
            MessageBox.Show("Oluyor");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            log.mailShare();
            timer1.Interval = 60000;
        }

    }
}
