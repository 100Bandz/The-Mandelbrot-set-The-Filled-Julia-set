using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Filled_Julia_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Bitmap bitmapImage = new Bitmap(pbNumberline.Width, pbNumberline.Height); //Creates the bitmap used to draw on

            double ca = -0.8;
            double cb = +0.156;

            const int zoom = 1;
            const int maxiteration = 100;
            const int MaxRGB = 255;
            int clr;

            var colors = (from c in Enumerable.Range(0, 256)
                          select Color.FromArgb((c >> 5) * 36, (c >> 3 & 7) * 36, (c & 3) * 85)).ToArray();

            for (int i = 0; i < pbNumberline.Width; i++)
            {
                for (int j = 0; j < pbNumberline.Height; j++)
                {
                    double za = (double)(i - (pbNumberline.Width / 2)) / (zoom * pbNumberline.Width * 0.5);
                    //Makes sure that a and b are in the range [-2,2]
                    double zb = (double)(j - (pbNumberline.Height / 2)) / (zoom * pbNumberline.Height * 0.5);

                    ComplexNumber c = new ComplexNumber(ca, cb);
                    ComplexNumber z = new ComplexNumber(za, zb);

                    int iteration = 0;
                    clr = MaxRGB;

                    while (iteration < maxiteration)
                    {
                        z.square();
                        z.add(c);

                        if (z.magnitude() > 2.00)
                        {
                            break;
                        }

                        iteration++;
                    }

                    if (iteration == maxiteration)
                    {
                        bitmapImage.SetPixel(i, j, Color.Aqua);
                    }
                    else
                    {
                        bitmapImage.SetPixel(i, j, Color.Black);

                    }

                }

            }
            pbNumberline.Image = bitmapImage;
        }

    }
}
