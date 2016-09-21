using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace First_Summative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           // this.BackgroundImage = Properties.Resources.phoenix;

            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Font drawFont = new Font("Arial", 30, FontStyle.Bold);
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush BlackBrush = new SolidBrush(Color.Black);

            formGraphics.Clear(Color.White);

            formGraphics.DrawString("Hello", drawFont, BlackBrush, 50, 40);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Font drawFont = new Font("Arial", 30, FontStyle.Bold);
            SolidBrush BlackBrush = new SolidBrush(Color.Purple);

            this.Size = new Size(450, 650);

            BackgroundImageLayout = ImageLayout.Stretch;

         //   formGraphics.Clear(Color.White);

            formGraphics.DrawString("Hello", drawFont, BlackBrush, 100, 400);



        }





    }
}
