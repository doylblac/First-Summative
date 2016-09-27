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

           Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);

           Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);

           Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);

            Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);

          Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);

           Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

           Thread.Sleep(500);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);

            formGraphics.FillEllipse(whiteBrush, 400, 145, 5, 5);













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
