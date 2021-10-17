using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomatik_Ders_Seçici
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            


            }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            {
                var dersler = new WebClient().DownloadString("https://hastebin.com/raw/soruxecuwi").Split('\n');
                bunifuMetroTextbox1.Text = dersler[new Random().Next(0, dersler.Length)];
            }
            {
                var sorular = new WebClient().DownloadString("https://hastebin.com/raw/iqimagamow").Split('\n');
                bunifuMetroTextbox2.Text = sorular[new Random().Next(0, sorular.Length)];
            }
            {
                var süre = new WebClient().DownloadString("https://hastebin.com/raw/unuriwiwut").Split('\n');
                bunifuMetroTextbox3.Text = süre[new Random().Next(0, süre.Length)];
            }
        }
        bool tutus;
        int FareX, FareY;

        public string MessageBox { get; private set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       


        

 

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var güncelleme = new WebClient().DownloadString("https://hastebin.com/raw/qitevuwoja").Split('\n');
            label5.Text = güncelleme[new Random().Next(0, güncelleme.Length)];
       
        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {

                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;

            }
        }

        
    }
    }

