using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleImageProcessing;

namespace PhotoProcesser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap origin;

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog(){Filter = "*.jpg|*.jpg"};
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                origin = (Bitmap) Image.FromFile(ofd.FileName);
                pictureBox1.Image = origin;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var src = new ImagerBitmap(origin.Clone() as Bitmap);
            var dst = new ImagerBitmap(origin.Clone() as Bitmap);
            
            for (int x = 1; x < src.Bitmap.Width-1; x++)
                for (int y = 1; y < src.Bitmap.Height-1; y++)
                {
                    Color c = src.GetPixel(x, y);
                    Color c1 = src.GetPixel(x-1, y);
                    Color c2 = src.GetPixel(x+1, y);

                    Color c3 = src.GetPixel(x-1, y+1);
                    Color c4 = src.GetPixel(x+1, y+1);
                    Color c5 = src.GetPixel(x-1, y-1);
                    Color c6 = src.GetPixel(x+1, y-1);

                    Color c7 = src.GetPixel(x, y+1);
                    Color c8 = src.GetPixel(x, y-1);

                    List<Color> colors = new List<Color>(){c,c1,c2,c3,c4,c5,c6,c7,c8};
                    colors.Sort(CompareColors);

                    var resultColor = colors[colors.Count/2];
                    dst.SetPixel(x,y,resultColor);
                }

            src.UnlockBitmap();
            dst.UnlockBitmap();

            pictureBox2.Image = dst.Bitmap;
        }

        private int CompareColors(Color c, Color c1)
        {
            double grey = (c.R * c.R + c.G * c.G + c.B * c.B) ;
            double grey1 = (c1.R * c1.R + c1.G * c1.G + c1.B * c1.B) ;
            return (int) (grey - grey1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var src = new ImagerBitmap(origin.Clone() as Bitmap);
            var dst = new ImagerBitmap(origin.Clone() as Bitmap);
            int treshold = trackBar1.Value;
            for (int x = 0; x < src.Bitmap.Width; x++)
                for (int y = 0; y < src.Bitmap.Height; y++)
                {
                    Color c = src.GetPixel(x, y);
                    double grey = Math.Sqrt(c.R * c.R + c.G * c.G + c.B * c.B) / Math.Sqrt(3);
                    double distance =
                        Math.Sqrt((c.R - grey) * (c.R - grey) + (c.G - grey) * (c.G - grey) + (c.B - grey) * (c.B - grey));
                    
                    if (distance < treshold)
                    {
                        dst.SetPixel(x, y, Color.FromArgb(c.G, c.B, c.R));
                    }
                    else
                    {
                        dst.SetPixel(x, y, c);
                    }
                }
            src.UnlockBitmap();
            dst.UnlockBitmap();

            pictureBox2.Image = dst.Bitmap;
        }
    }
}
