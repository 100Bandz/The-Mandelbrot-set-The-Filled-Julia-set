using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot_set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)    //Literally does whatever is codded, when the form is first shown
        {
            Bitmap bitmapImage = new Bitmap(pbNumberline.Width, pbNumberline.Height);

            for (int x = 0; x < pbNumberline.Width; x++)
            {
                for (int y = 0; y < pbNumberline.Height; y++)
                {
                    double a = (double)(x - (pbNumberline.Width / 2)) / (double)(pbNumberline.Width / 4);
                    double b = (double)(y - (pbNumberline.Height / 2)) / (double)(pbNumberline.Height / 4);

                    ComplexNumber c = new ComplexNumber(a, b);
                    ComplexNumber z = new ComplexNumber(0, 0);

                    int iteration = 0;

                    while (iteration < 100)
                    {
                        iteration++;
                        z.square();
                        z.add(c);
                        if (z.magnitude() > 2.0)
                        {
                            break;
                        }
                    }
                    bitmapImage.SetPixel(x, y, iteration < 100 ? Color.Black : Color.White);
                }
            }
            pbNumberline.Image = bitmapImage;

        }
    }
}
