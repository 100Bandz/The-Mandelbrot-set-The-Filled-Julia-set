using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace Mandelbrot_set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double MaxValueExtent = 2.0;

        private void DrawSet(Bitmap bitmapImage)
        {

            const byte zoom = 1;
            const int maxiteration = 1000;
            const byte MaxRGB = 255;

            double scale = 2 * MaxValueExtent / Math.Min(bitmapImage.Width, bitmapImage.Height);

            for (int x = 0; x < pbNumberline.Width; x++)
            {
                for (int y = 0; y < pbNumberline.Height; y++)
                {
                    double a = (x- bitmapImage.Width / 2 ) * scale;
                    //Makes sure that a and b are in the range [-2,2]
                    double b = (y - bitmapImage.Height / 2) * scale;

                    ComplexNumber c = new ComplexNumber(a, b);
                    ComplexNumber z = new ComplexNumber(0, 0);  //Looking at the behaviour of 0 under iteration

                    int iteration = 0;
                    var clr = MaxRGB;

                    do
                    {
                        iteration++;
                        z.square();
                        z.add(c);
                        if (z.magnitude() > 2.0) //if magnitude is > 2.0 then the iterations will go to infinity
                        {
                            break;
                        }

                        clr -= 1;

                    } while (iteration < maxiteration && clr > 1);

                    bitmapImage.SetPixel(x, y, Color.FromArgb(iteration % 58, iteration % 60 * 3, iteration % 200));  //colors[clr]);
                }
            }
            pbNumberline.Image = bitmapImage;

        }

        private void Form1_Shown(object sender, EventArgs e)    //Literally does whatever is codded, when the form is first shown
        {
            Bitmap bitmapImage = new Bitmap(pbNumberline.Width, pbNumberline.Height);   //Creates the bitmap used to draw on
            DrawSet(bitmapImage);

        }

    }
}
