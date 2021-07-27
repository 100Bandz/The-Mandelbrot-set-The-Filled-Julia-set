using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Filled_Julia_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double ca = -0.8;   //Constant C value components
        public double cb = +0.156;

        public void DrawJulia()
        {
            Bitmap bitmapImage = new Bitmap(pbNumberline.Width, pbNumberline.Height); //Creates the bitmap used to draw on

            const int zoom = 1;
            const int maxiteration = 1000;
            const int MaxRGB = 255;
            int clr;

            var colors = (from c in Enumerable.Range(0, 256)    //Colour array that lets makes each iteration a different colour
                select Color.FromArgb((c >> 5) * 36, (c >> 3 & 7) * 36, (c & 3) * 85)).ToArray();

            for (int i = 0; i < pbNumberline.Width; i++)
            {
                for (int j = 0; j < pbNumberline.Height; j++)
                {
                    //Each component is scaled to be between [-2,2]
                    double za = (double)(i - (pbNumberline.Width / 2)) / (zoom * pbNumberline.Width * 0.5); //Real component of Z
                    double zb = (double)(j - (pbNumberline.Height / 2)) / (zoom * pbNumberline.Height * 0.5);   //Imaginary component of Z

                    ComplexNumber c = new ComplexNumber(ca, cb);
                    ComplexNumber z = new ComplexNumber(za, zb);

                    int iteration = 0;
                    clr = MaxRGB;

                    while (iteration < maxiteration && clr > 1)
                    {
                        z.square();
                        z.add(c);

                        if (z.magnitude() > 2.00)
                        {
                            break;
                        }

                        clr -= 1;
                        iteration++;
                    }

                    if (iteration < 1000)
                    {
                        bitmapImage.SetPixel(i, j, Color.FromArgb(iteration % 58, iteration % 60 * 3, iteration % 200));  //colors[clr]);

                    }
                }
            }
            pbNumberline.Image = bitmapImage;
            Refresh();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
          DrawJulia();
        }


    }
}
