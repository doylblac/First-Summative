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
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            this.Size = new Size(450, 650);

            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Font largeFont = new Font("Arial", 25, FontStyle.Bold);
            Font smallFont = new Font("Arial", 15, FontStyle.Bold);
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen whitePen = new Pen(Color.White, 3);

            formGraphics.DrawString("Phoenix Greeting Card", largeFont, whiteBrush, 30, 160);
            formGraphics.DrawString("Doyle Blacklock", smallFont, whiteBrush, 0, 500);
            formGraphics.DrawString("September, 29, 2016", smallFont, whiteBrush, 0, 550);

            Thread.Sleep(3000);

            formGraphics.Clear(Color.Black);

           Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);

           Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);

           Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);

          Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);

           Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

           Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 236, 432, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);

            Thread.Sleep(100);

            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            Thread.Sleep(1000);

            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);

                 Thread.Sleep(500);

            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);

                Thread.Sleep(500);

            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);

                Thread.Sleep(500);

            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);

               Thread.Sleep(500);

            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);

                Thread.Sleep(500);

            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);

                Thread.Sleep(500);

            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);

               Thread.Sleep(500);

            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);

                Thread.Sleep(500);

            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);



        }


    }
}
