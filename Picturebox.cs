using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
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

        private void LoadBTN_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"C:\Users\adam.chaudhry\Downloads\IMG_9244.jpg");
            openFileDialog1.ShowDialog();
            string filepath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filepath);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\adam.chaudhry\Downloads\IMG_9244.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"C:\Users\adam.chaudhry\Downloads\IMG_9244.jpg");
        }
    }
}
