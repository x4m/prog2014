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

        ImagerBitmap src;
        private void button2_Click(object sender, EventArgs e)
        {
            src = new ImagerBitmap(origin.Clone() as Bitmap);
            var dst = new ImagerBitmap(origin.Clone() as Bitmap);
            
            for (int x = 1; x < src.Bitmap.Width-1; x++)
                for (int y = 1; y < src.Bitmap.Height-1; y++)
                {
                    /*if(TestIfCircle(x,y))
                    dst.SetPixel(x,y,Color.Red);*/
                }

            DrawCircle(dst,256,256,200);

            src.UnlockBitmap();
            dst.UnlockBitmap();

            pictureBox2.Image = dst.Bitmap;
        }

        private bool TestIfCircle(int x, int y)
        {
            //Dictionary<int,double>intensity = new Dictionary<int, double>();

            double lastIntensity = -1;
            for (int r = 8; r < 20; r++)
            {
                if (lastIntensity == -1)
                {
                    lastIntensity = GetCircleIntensity(x, y, r);
                }
                else
                {
                    var currentIntensity = GetCircleIntensity(x, y, r);
                    if (currentIntensity - lastIntensity > 20)
                        return true;
                    lastIntensity = currentIntensity;
                }

                //intensity[r] = GetCircleIntensity( x, y, r);
            }
            /*for (int r = 9; r < 30; r++)
            {
                if (intensity[r] - intensity[r - 1] > 20)
                    return true;
            }*/
            return false;
        }

        private double intensity;
        private int count;

        private double GetCircleIntensity(int x0, int y0, int radius)
        {
            int x = radius, y = 0;
            int radiusError = 1 - x;

            intensity = 0;
            count = 0;

            while (x >= y)
            {
                DumpPixed(x + x0, y + y0);
                DumpPixed(y + x0, x + y0);
                DumpPixed(-x + x0, y + y0);
                DumpPixed(-y + x0, x + y0);
                DumpPixed(-x + x0, -y + y0);
                DumpPixed(-y + x0, -x + y0);
                DumpPixed(x + x0, -y + y0);
                DumpPixed(y + x0, -x + y0);
                y++;
                if (radiusError < 0)
                {
                    radiusError += 2 * y + 1;
                }
                else
                {
                    x--;
                    radiusError += 2 * (y - x + 1);
                }
            }
            if (count == 0)
                return 0;
            return intensity/count;
        }

        private void DumpPixed(int x, int y)
        {
            if(x<0||y<0)
                return;
            if(x>=src.Bitmap.Width || y>=src.Bitmap.Height)
                return;
            count++;
            intensity += src.GetPixel(x, y).R;
        }

        public void DrawCircle(ImagerBitmap src, int x0, int y0, int radius)
        {
            int x = radius, y = 0;
            int radiusError = 1 - x;

            while (x >= y)
            {
                src.SetPixel(x + x0, y + y0,Color.Red);
                src.SetPixel(y + x0, x + y0, Color.Red);
                src.SetPixel(-x + x0, y + y0, Color.Red);
                src.SetPixel(-y + x0, x + y0, Color.Red);
                src.SetPixel(-x + x0, -y + y0, Color.Red);
                src.SetPixel(-y + x0, -x + y0, Color.Red);
                src.SetPixel(x + x0, -y + y0, Color.Red);
                src.SetPixel(y + x0, -x + y0, Color.Red);
                y++;
                if (radiusError < 0)
                {
                    radiusError += 2 * y + 1;
                }
                else
                {
                    x--;
                    radiusError += 2 * (y - x + 1);
                }
            }
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
