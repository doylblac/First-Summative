//Made by Doyle Blacklock on September 29,2016
//To create a greeting card which shows the Phoenix Constellation
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
using System.Media;

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

            this.Size = new Size(470, 650);//Resizes the form to look like a greeting card

            BackgroundImageLayout = ImageLayout.Stretch;//Stretches the background image to fit the form
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Font largeFont = new Font("Courier", 25, FontStyle.Bold);//Creates a new font variable
            Font smallFont = new Font("Georgia", 15, FontStyle.Bold);//Creates a new font variable
            Font tinyFont = new Font("Arial", 10, FontStyle.Bold);//Creates a new font variable
            Graphics formGraphics = this.CreateGraphics();//Creates a graphics variable
            SolidBrush whiteBrush = new SolidBrush(Color.White);//Creates a white brush
            SolidBrush greenBrush = new SolidBrush(Color.Green);//Creates a green brush
            Pen whitePen = new Pen(Color.White, 3);//Creates a white pen
            Pen redPen = new Pen(Color.Red, 3);//Creates a red pen 
            Pen yellowPen = new Pen(Color.Yellow, 3);//Creates a yellow pen
            Pen bluePen = new Pen(Color.Blue, 3);//Creates a blue pen
            Pen purplePen = new Pen(Color.Purple, 3);//Creates a blue pen
            SoundPlayer ding = new SoundPlayer(Properties.Resources._66136__theta4__ding30603_spedup);//Creates a new sound variable
            SoundPlayer tada = new SoundPlayer(Properties.Resources.TaDa_);//Creates a sound variable
            int number = 3;//Declares the numer value as 3

            formGraphics.DrawString("Phoenix Greeting Card", largeFont, whiteBrush, 30, 160);//Writes words into the form
            formGraphics.DrawString("Doyle Blacklock", smallFont, whiteBrush, 0, 500);//Writes words into the form
            formGraphics.DrawString("September, 29, 2016", smallFont, whiteBrush, 0, 550);//Writes words into the form

            Thread.Sleep(3000);//Delays for 3 seconds

            formGraphics.Clear(Color.Black);//Clears the screen and makes and it black

            //Draws the main constellation stars
            Thread.Sleep(500);//Delays for half a second
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);//Draws a main star for the constellation
            ding.Play();//Plays the ding noise
            Thread.Sleep(500);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            ding.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            ding.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            ding.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            ding.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            ding.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            ding.Play();
            Thread.Sleep(500);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            ding.Play();
            Thread.Sleep(500);//Delays for half a second
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);//Draws a main star for the constellation
            ding.Play();//Plays the ding noise
            Thread.Sleep(500);//Delays for half a second

            //Draws the smaller stars which surrond the constellation
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);//Draws a smaller star
            Thread.Sleep(100);//Delays for 100 milliseconds
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
            Thread.Sleep(100);//Delays for 100 milliseconds
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);//Draws a smaller star
            Thread.Sleep(1000);//Delays for one second

            //Connects the constellation together
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);//Draws a line that connects the constellation
            Thread.Sleep(500);//Delays for half a second
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
            Thread.Sleep(500);//Delays for half a second
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);//Draws a line that connects the constellation
            Thread.Sleep(200);//Delays for 200 milliseconds


            for (int i = 0; i < number; i++)
            {
                //Draws red lines where the constellation lines are
                formGraphics.DrawLine(redPen, 30, 165, 114, 90);
                formGraphics.DrawLine(redPen, 33, 165, 115, 210);
                formGraphics.DrawLine(redPen, 117, 210, 195, 155);
                formGraphics.DrawLine(redPen, 115, 95, 195, 150);
                formGraphics.DrawLine(redPen, 195, 155, 345, 65);
                formGraphics.DrawLine(redPen, 341, 65, 341, 95);
                formGraphics.DrawLine(redPen, 341, 95, 408, 153);
                formGraphics.DrawLine(redPen, 117, 210, 200, 330);
                formGraphics.DrawLine(redPen, 200, 330, 270, 370);

                Thread.Sleep(200);//Waits for 200 milliseconds

                //Draws yellow lines where the constellation lines are
                formGraphics.DrawLine(yellowPen, 30, 165, 114, 90);
                formGraphics.DrawLine(yellowPen, 33, 165, 115, 210);
                formGraphics.DrawLine(yellowPen, 117, 210, 195, 155);
                formGraphics.DrawLine(yellowPen, 115, 95, 195, 150);
                formGraphics.DrawLine(yellowPen, 195, 155, 345, 65);
                formGraphics.DrawLine(yellowPen, 341, 65, 341, 95);
                formGraphics.DrawLine(yellowPen, 341, 95, 408, 153);
                formGraphics.DrawLine(yellowPen, 117, 210, 200, 330);
                formGraphics.DrawLine(yellowPen, 200, 330, 270, 370);

                Thread.Sleep(200);//Waits for 200 milliseconds

                //Draws blue lines where where the constellation lines are
                formGraphics.DrawLine(bluePen, 30, 165, 114, 90);
                formGraphics.DrawLine(bluePen, 33, 165, 115, 210);
                formGraphics.DrawLine(bluePen, 117, 210, 195, 155);
                formGraphics.DrawLine(bluePen, 115, 95, 195, 150);
                formGraphics.DrawLine(bluePen, 195, 155, 345, 65);
                formGraphics.DrawLine(bluePen, 341, 65, 341, 95);
                formGraphics.DrawLine(bluePen, 341, 95, 408, 153);
                formGraphics.DrawLine(bluePen, 117, 210, 200, 330);
                formGraphics.DrawLine(bluePen, 200, 330, 270, 370);

                Thread.Sleep(200);//Delays for 200 miliiseconds

                //Draws purple lines where the constellation lines are
                formGraphics.DrawLine(purplePen, 30, 165, 114, 90);
                formGraphics.DrawLine(purplePen, 33, 165, 115, 210);
                formGraphics.DrawLine(purplePen, 117, 210, 195, 155);
                formGraphics.DrawLine(purplePen, 115, 95, 195, 150);
                formGraphics.DrawLine(purplePen, 195, 155, 345, 65);
                formGraphics.DrawLine(purplePen, 341, 65, 341, 95);
                formGraphics.DrawLine(purplePen, 341, 95, 408, 153);
                formGraphics.DrawLine(purplePen, 117, 210, 200, 330);
                formGraphics.DrawLine(purplePen, 200, 330, 270, 370);

                Thread.Sleep(200);//Delays for 200 milliseconds
            }
            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            Thread.Sleep(50);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            Thread.Sleep(50);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            Thread.Sleep(50);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            Thread.Sleep(50);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            Thread.Sleep(50);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            Thread.Sleep(50);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            Thread.Sleep(50);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            Thread.Sleep(50);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);
            Thread.Sleep(50);

            tada.Play();//Plays the tada sound

            Thread.Sleep(3000);//Delays for three seconds

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 600);

            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 580);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 600);

            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 560);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 580);
            formGraphics.DrawString("by the Dutch astronomer Petrus Planceus. He discovered it in 1598.", tinyFont, greenBrush, 10, 600);

            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 540);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 560);
            formGraphics.DrawString("by the Dutch astronomer Petrus Planceus. He discovered it in 1598.", tinyFont, greenBrush, 10, 580);
            formGraphics.DrawString("Phoenix contains 5 stars with known planets and 9 in total.", tinyFont, greenBrush, 10, 600);

            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 520);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 540);
            formGraphics.DrawString("by the Dutch astronomer Petrus Planceus. He discovered it in 1598.", tinyFont, greenBrush, 10, 560);
            formGraphics.DrawString("Phoenix contains 5 stars with known planets and 9 in total.", tinyFont, greenBrush, 10, 580);
            formGraphics.DrawString("The name Phoenix comes from the mythical bird which originated", tinyFont, greenBrush, 10, 600);

            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 500);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 520);
            formGraphics.DrawString("by the Dutch astronomer Petrus Planceus. He discovered it in 1598.", tinyFont, greenBrush, 10, 540);
            formGraphics.DrawString("Phoenix contains 5 stars with known planets and 9 in total.", tinyFont, greenBrush, 10, 560);
            formGraphics.DrawString("The name Phoenix comes from the mythical bird which originated", tinyFont, greenBrush, 10, 580);
            formGraphics.DrawString("from several cultures. These cultures include Greek, Persian,", tinyFont, greenBrush, 10, 600);

            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 480);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 500);
            formGraphics.DrawString("by the Dutch astronomer Petrus Planceus. He discovered it in 1598.", tinyFont, greenBrush, 10, 520);
            formGraphics.DrawString("Phoenix contains 5 stars with known planets and 9 in total.", tinyFont, greenBrush, 10, 540);
            formGraphics.DrawString("The name Phoenix comes from the mythical bird which originated", tinyFont, greenBrush, 10, 560);
            formGraphics.DrawString("from several cultures. These cultures include Greek, Persian,", tinyFont, greenBrush, 10, 580);
            formGraphics.DrawString("Arabic, Egyptian, Roman, Turkish, Indian and Chinese.", tinyFont, greenBrush, 10, 600);

            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 460);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 480);
            formGraphics.DrawString("by the Dutch astronomer Petrus Planceus. He discovered it in 1598.", tinyFont, greenBrush, 10, 500);
            formGraphics.DrawString("Phoenix contains 5 stars with known planets and 9 in total.", tinyFont, greenBrush, 10, 520);
            formGraphics.DrawString("The name Phoenix comes from the mythical bird which originated", tinyFont, greenBrush, 10, 540);
            formGraphics.DrawString("from several cultures. These cultures include Greek, Persian,", tinyFont, greenBrush, 10, 560);
            formGraphics.DrawString("Arabic, Egyptian, Roman, Turkish, Indian and Chinese.", tinyFont, greenBrush, 10, 580);
            formGraphics.DrawString("The Phoenix is a bird which can ignite and be reborn", tinyFont, greenBrush, 10, 600);


            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 440);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 460);
            formGraphics.DrawString("by the Dutch astronomer Petrus Planceus. He discovered it in 1598.", tinyFont, greenBrush, 10, 480);
            formGraphics.DrawString("Phoenix contains 5 stars with known planets and 9 in total.", tinyFont, greenBrush, 10, 500);
            formGraphics.DrawString("The name Phoenix comes from the mythical bird which originated", tinyFont, greenBrush, 10, 520);
            formGraphics.DrawString("from several cultures. These cultures include Greek, Persian,", tinyFont, greenBrush, 10, 540);
            formGraphics.DrawString("Arabic, Egyptian, Roman, Turkish, Indian and Chinese.", tinyFont, greenBrush, 10, 560);
            formGraphics.DrawString("The Phoenix is a bird which can ignite and be reborn", tinyFont, greenBrush, 10, 580);
            formGraphics.DrawString("from it's own ashes.", tinyFont, greenBrush, 10, 600);

            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 420);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 440);
            formGraphics.DrawString("by the Dutch astronomer Petrus Planceus. He discovered it in 1598.", tinyFont, greenBrush, 10, 460);
            formGraphics.DrawString("Phoenix contains 5 stars with known planets and 9 in total.", tinyFont, greenBrush, 10, 480);
            formGraphics.DrawString("The name Phoenix comes from the mythical bird which originated", tinyFont, greenBrush, 10, 500);
            formGraphics.DrawString("from several cultures. These cultures include Greek, Persian,", tinyFont, greenBrush, 10, 520);
            formGraphics.DrawString("Arabic, Egyptian, Roman, Turkish, Indian and Chinese.", tinyFont, greenBrush, 10, 540);
            formGraphics.DrawString("The Phoenix is a bird which can ignite and be reborn", tinyFont, greenBrush, 10, 560);
            formGraphics.DrawString("from it's own ashes.", tinyFont, greenBrush, 10, 580);

            Thread.Sleep(500);//Delays for half a second

            formGraphics.Clear(Color.Black);//Clears the screen and makes it black

            //Draws the main stars
            formGraphics.FillEllipse(whiteBrush, 28, 160, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 106, 88, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 112, 204, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 148, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 192, 322, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 264, 364, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 62, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 336, 90, 10, 10);
            formGraphics.FillEllipse(whiteBrush, 400, 145, 10, 10);

            //Draws the smaller stars
            formGraphics.FillEllipse(whiteBrush, 53, 228, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 33, 196, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 51, 382, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 305, 47, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 347, 54, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 217, 90, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 250, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 175, 446, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 470, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 323, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 47, 92, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 283, 318, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 50, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 315, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 55, 264, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 55, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 40, 230, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 205, 190, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 140, 420, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 70, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 125, 370, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 325, 400, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 300, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 240, 15, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 25, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 106, 30, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 350, 37, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 276, 100, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 389, 207, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 230, 645, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 50, 600, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 60, 620, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 80, 625, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 90, 630, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 580, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 30, 150, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 75, 180, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 89, 132, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 153, 176, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 35, 300, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 65, 173, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 15, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 45, 585, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 85, 575, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 560, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 390, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 400, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 430, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 385, 500, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 250, 545, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 225, 535, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 275, 570, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 235, 550, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 216, 520, 5, 5);
            formGraphics.FillEllipse(whiteBrush, 189, 568, 5, 5);

            //Draws white constellation lines
            formGraphics.DrawLine(whitePen, 30, 165, 114, 90);
            formGraphics.DrawLine(whitePen, 33, 165, 115, 210);
            formGraphics.DrawLine(whitePen, 117, 210, 195, 155);
            formGraphics.DrawLine(whitePen, 115, 95, 195, 150);
            formGraphics.DrawLine(whitePen, 195, 155, 345, 65);
            formGraphics.DrawLine(whitePen, 341, 65, 341, 95);
            formGraphics.DrawLine(whitePen, 341, 95, 408, 153);
            formGraphics.DrawLine(whitePen, 117, 210, 200, 330);
            formGraphics.DrawLine(whitePen, 200, 330, 270, 370);

            //Writes the information for the constellation
            formGraphics.DrawString("Phoenix Constellation", smallFont, greenBrush, 150, 200);
            formGraphics.DrawString("The Phoenix Constellation lies in the Southern sky. It is mainly", tinyFont, greenBrush, 10, 400);
            formGraphics.DrawString("visible from Australia and South Africa. It was first discovered", tinyFont, greenBrush, 10, 420);
            formGraphics.DrawString("by the Dutch astronomer Petrus Planceus. He discovered it in 1598.", tinyFont, greenBrush, 10, 440);
            formGraphics.DrawString("Phoenix contains 5 stars with known planets and 9 in total.", tinyFont, greenBrush, 10, 460);
            formGraphics.DrawString("The name Phoenix comes from the mythical bird which originated", tinyFont, greenBrush, 10, 480);
            formGraphics.DrawString("from several cultures. These cultures include Greek, Persian,", tinyFont, greenBrush, 10, 500);
            formGraphics.DrawString("Arabic, Egyptian, Roman, Turkish, Indian and Chinese.", tinyFont, greenBrush, 10, 520);
            formGraphics.DrawString("The Phoenix is a bird which can ignite and be reborn", tinyFont, greenBrush, 10, 540);
            formGraphics.DrawString("from it's own ashes.", tinyFont, greenBrush, 10, 560);

            for (int i = 0; i < number; i++)//Loops the following program 3 times
            {
                //Draws a border around the text and flashes different colours
                formGraphics.DrawRectangle(bluePen, 5, 395, 440, 185);
                Thread.Sleep(200);
                formGraphics.DrawRectangle(yellowPen, 5, 395, 440, 185);
                Thread.Sleep(200);
                formGraphics.DrawRectangle(redPen, 5, 395, 440, 185);
                Thread.Sleep(200);
                formGraphics.DrawRectangle(purplePen, 5, 395, 440, 185);
                Thread.Sleep(200);
            }
            //Makes the border around the rectangle white
            formGraphics.DrawRectangle(whitePen, 5, 395, 440, 185);

        }


    }
}
