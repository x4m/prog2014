using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private bool X_or_O, win_;
        private bool pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9;
        private int winX, winO;
        System.Drawing.Bitmap X = tic_tac_toe.Properties.Resources.X;
        System.Drawing.Bitmap O = tic_tac_toe.Properties.Resources.O;
        public Form1()  {
            winX = 0;
            winO = 0;
            pic1 = false;
            pic2 = false;
            pic3 = false;
            pic4 = false;
            pic5 = false;
            pic6 = false;
            pic7 = false;
            pic8 = false;
            pic9 = false;
            win_ = false;
            X_or_O = false;
            InitializeComponent();
            label1.Text +="="+ winX.ToString();
            label2.Text +="="+ winO.ToString();
            one_p_ToolStripMenuItem.Checked = true;
            mult_p_ToolStripMenuItem.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == true)
            {
                if (pic1 == false)
                {
                    if (X_or_O == false)
                    {
                        pictureBox1.Image = X;
                        X_or_O = true;
                    }
                    else
                    {
                        pictureBox1.Image = O;
                        X_or_O = false;
                    }
                    pic1 = true;
                }
                win();
                all_click();
            }
            else
            {
                if (pic1 == false)
                {
                    pictureBox1.Image = X;
                    pic1 = true;
                    win();
                a:
                    int pic = rand.Next(9) + 1;
                    int notX = 5;
                    notX = win_Comp();
                    if (notX == 0)
                    {
                        if (pic5 == false)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else if (pic == 2 && pic2 == false && win_ == false && comp_game() > 8)
                        {
                            pictureBox2.Image = O;
                            pic2 = true;
                        }
                        else if (pic == 3 && pic3 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox3.Image = O;
                            pic3 = true;
                        }
                        else if (pic == 4 && pic4 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox4.Image = O;
                            pic4 = true;
                        }
                        else if (pic == 5 && pic5 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else if (pic == 6 && pic6 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox6.Image = O;
                            pic6 = true;
                        }
                        else if (pic == 7 && pic7 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox7.Image = O;
                            pic7 = true;
                        }
                        else if (pic == 8 && pic8 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox8.Image = O;
                            pic8 = true;
                        }
                        else if (pic == 9 && pic9 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox9.Image = O;
                            pic9 = true;
                        }
                        else if (win_ == false && comp_game() < 8)
                            goto a;
                    }
                    win();
                    all_click();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == true)
            {
                if (pic2 == false)
                {
                    if (X_or_O == false)
                    {
                        pictureBox2.Image = X;
                        X_or_O = true;
                    }
                    else
                    {
                        pictureBox2.Image = O;
                        X_or_O = false;
                    }
                    pic2 = true;
                }
                win();
                all_click();
            }
            else
            {
                if (pic2 == false)
                {
                    pictureBox2.Image = X;
                    pic2 = true;
                    win();
                a: int pic = rand.Next(9) + 1;
                    int notX = 5;
                    notX = win_Comp();
                    if (notX == 0)
                    {
                        if (pic5 == false)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else
                            if (pic == 1 && pic1 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox1.Image = O;
                                pic1 = true;
                            }
                            else if (pic == 3 && pic3 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox3.Image = O;
                                pic3 = true;
                            }
                            else if (pic == 4 && pic4 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox4.Image = O;
                                pic4 = true;
                            }
                            else if (pic == 5 && pic5 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox5.Image = O;
                                pic5 = true;
                            }
                            else if (pic == 6 && pic6 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox6.Image = O;
                                pic6 = true;
                            }
                            else if (pic == 7 && pic7 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox7.Image = O;
                                pic7 = true;
                            }
                            else if (pic == 8 && pic8 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox8.Image = O;
                                pic8 = true;
                            }
                            else if (pic == 9 && pic9 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox9.Image = O;
                                pic9 = true;
                            }
                            else if (win_ == false && comp_game() < 8)
                                goto a;
                    }
                    win();
                    all_click();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == true)
            {
                if (pic3 == false)
                {
                    if (X_or_O == false)
                    {
                        if (mult_p_ToolStripMenuItem.Checked == true)
                        {
                            if (pic3 == false)
                            {
                                if (X_or_O == false)
                                {
                                    pictureBox3.Image = X;
                                    X_or_O = true;
                                }
                                else
                                {
                                    pictureBox3.Image = O;
                                    X_or_O = false;
                                }
                                pic3 = true;
                            }
                            win();
                            all_click();
                        }
                        else
                        {
                            if (pic3 == false)
                            {
                                pictureBox3.Image = X;
                                pic3 = true;
                                win();
                            a: int pic = rand.Next(9) + 1;
                                int notX = 5;
                                notX = win_Comp();
                                if (notX == 0)
                                {
                                    if (pic5 == false)
                                    {
                                        pictureBox5.Image = O;
                                        pic5 = true;
                                    }
                                    else
                                        if (pic == 1 && pic1 == false && win_ == false && comp_game() < 8)
                                        {
                                            pictureBox1.Image = O;
                                            pic1 = true;
                                        }
                                        else if (pic == 2 && pic2 == false && win_ == false && comp_game() < 8)
                                        {
                                            pictureBox2.Image = O;
                                            pic2 = true;
                                        }
                                        else if (pic == 4 && pic4 == false && win_ == false && comp_game() < 8)
                                        {
                                            pictureBox4.Image = O;
                                            pic4 = true;
                                        }
                                        else if (pic == 5 && pic5 == false && win_ == false && comp_game() < 8)
                                        {
                                            pictureBox5.Image = O;
                                            pic5 = true;
                                        }
                                        else if (pic == 6 && pic6 == false && win_ == false && comp_game() < 8)
                                        {
                                            pictureBox6.Image = O;
                                            pic6 = true;
                                        }
                                        else if (pic == 7 && pic7 == false && win_ == false && comp_game() < 8)
                                        {
                                            pictureBox7.Image = O;
                                            pic7 = true;
                                        }
                                        else if (pic == 8 && pic8 == false && win_ == false && comp_game() < 8)
                                        {
                                            pictureBox8.Image = O;
                                            pic8 = true;
                                        }
                                        else if (pic == 9 && pic9 == false && win_ == false && comp_game() < 8)
                                        {
                                            pictureBox9.Image = O;
                                            pic9 = true;
                                        }
                                        else if (win_ == false && comp_game() < 8)
                                            goto a;
                                }
                                win();
                                all_click();
                            }
                        }
                        X_or_O = true;
                    }
                    else
                    {
                        pictureBox3.Image = O;
                        X_or_O = false;
                    }
                    pic3 = true;
                }
                win();
                all_click();
            }
            else
            {
                if (pic3 == false)
                {
                    pictureBox3.Image = X;
                    pic3 = true;
                    win();
                a: int pic = rand.Next(9) + 1;
                    int notX = 5;
                    notX = win_Comp();
                    if (notX == 0)
                    {
                        if (pic5 == false)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else
                            if (pic == 1 && pic1 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox1.Image = O;
                                pic1 = true;
                            }
                            else if (pic == 2 && pic2 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox2.Image = O;
                                pic2 = true;
                            }
                            else if (pic == 4 && pic4 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox4.Image = O;
                                pic4 = true;
                            }
                            else if (pic == 5 && pic5 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox5.Image = O;
                                pic5 = true;
                            }
                            else if (pic == 6 && pic6 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox6.Image = O;
                                pic6 = true;
                            }
                            else if (pic == 7 && pic7 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox7.Image = O;
                                pic7 = true;
                            }
                            else if (pic == 8 && pic8 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox8.Image = O;
                                pic8 = true;
                            }
                            else if (pic == 9 && pic9 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox9.Image = O;
                                pic9 = true;
                            }
                            else if (win_ == false && comp_game() < 8)
                                goto a;
                    }
                    win();
                    all_click();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == true)
            {
                if (pic4 == false)
                {
                    if (X_or_O == false)
                    {
                        pictureBox4.Image = X;
                        X_or_O = true;
                    }
                    else
                    {
                        pictureBox4.Image = O;
                        X_or_O = false;
                    }
                    pic4 = true;
                }
                win();
                all_click();
            }
            else
            {
                if (pic4 == false)
                {
                    pictureBox4.Image = X;
                    pic4 = true;
                    win();
                a: int pic = rand.Next(9) + 1;
                    int notX = 5;
                    notX = win_Comp();
                    if (notX == 0)
                    {
                        if (pic5 == false)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else if (pic == 1 && pic1 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox1.Image = O;
                            pic1 = true;
                        }
                        else if (pic == 3 && pic3 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox3.Image = O;
                            pic3 = true;
                        }
                        else if (pic == 2 && pic2 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox2.Image = O;
                            pic2 = true;
                        }
                        else if (pic == 5 && pic5 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else if (pic == 6 && pic6 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox6.Image = O;
                            pic6 = true;
                        }
                        else if (pic == 7 && pic7 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox7.Image = O;
                            pic7 = true;
                        }
                        else if (pic == 8 && pic8 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox8.Image = O;
                            pic8 = true;
                        }
                        else if (pic == 9 && pic9 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox9.Image = O;
                            pic9 = true;
                        }
                        else if (win_ == false && comp_game() < 8)
                            goto a;
                    }
                    win();
                    all_click();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == true)
            {
                if (pic5 == false)
                {
                    if (X_or_O == false)
                    {
                        pictureBox5.Image = X;
                        X_or_O = true;
                    }
                    else
                    {
                        pictureBox5.Image = O;
                        X_or_O = false;
                    }
                    pic5 = true;
                }
                win();
                all_click();
            }
            else
            {
                if (pic5 == false)
                {
                    pictureBox5.Image = X;
                    pic5 = true;
                    win();
                a: int pic = rand.Next(9) + 1;
                    int notX = 5;
                    notX = win_Comp();
                    if (notX == 0)
                    {
                        if (pic == 1 && pic1 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox1.Image = O;
                            pic1 = true;
                        }
                        else if (pic == 3 && pic3 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox3.Image = O;
                            pic3 = true;
                        }
                        else if (pic == 4 && pic4 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox4.Image = O;
                            pic4 = true;
                        }
                        else if (pic == 2 && pic2 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox2.Image = O;
                            pic2 = true;
                        }
                        else if (pic == 6 && pic6 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox6.Image = O;
                            pic6 = true;
                        }
                        else if (pic == 7 && pic7 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox7.Image = O;
                            pic7 = true;
                        }
                        else if (pic == 8 && pic8 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox8.Image = O;
                            pic8 = true;
                        }
                        else if (pic == 9 && pic9 == false && win_ == false && comp_game() < 8)
                        {
                            pictureBox9.Image = O;
                            pic9 = true;
                        }
                        else if (win_ == false && comp_game() < 8)
                            goto a;
                    }
                    win();
                    all_click();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == true)
            {
                if (pic6 == false)
                {
                    if (X_or_O == false)
                    {
                        pictureBox6.Image = X;
                        X_or_O = true;
                    }
                    else
                    {
                        pictureBox6.Image = O;
                        X_or_O = false;
                    }
                    pic6 = true;
                }
                win();
                all_click();
            }
            else
            {
                if (pic6 == false)
                {
                    pictureBox6.Image = X;
                    pic6 = true;
                    win();
                a: int pic = rand.Next(9) + 1;
                    int notX = 5;
                    notX = win_Comp();
                    if (notX == 0)
                    {
                        if (pic5 == false)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else
                            if (pic == 1 && pic1 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox1.Image = O;
                                pic1 = true;
                            }
                            else if (pic == 3 && pic3 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox3.Image = O;
                                pic3 = true;
                            }
                            else if (pic == 4 && pic4 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox4.Image = O;
                                pic4 = true;
                            }
                            else if (pic == 5 && pic5 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox5.Image = O;
                                pic5 = true;
                            }
                            else if (pic == 2 && pic2 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox2.Image = O;
                                pic2 = true;
                            }
                            else if (pic == 7 && pic7 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox7.Image = O;
                                pic7 = true;
                            }
                            else if (pic == 8 && pic8 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox8.Image = O;
                                pic8 = true;
                            }
                            else if (pic == 9 && pic9 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox9.Image = O;
                                pic9 = true;
                            }
                            else if (win_ == false && comp_game() < 8)
                                goto a;
                    }
                    win();
                    all_click();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == true)
            {
                if (pic7 == false)
                {
                    if (X_or_O == false)
                    {
                        pictureBox7.Image = X;
                        X_or_O = true;
                    }
                    else
                    {
                        pictureBox7.Image = O;
                        X_or_O = false;
                    }
                    pic7 = true;
                }
                win();
                all_click();
            }
            else
            {
                if (pic7 == false)
                {
                    pictureBox7.Image = X;
                    pic7 = true;
                    win();
                a: int pic = rand.Next(9) + 1;
                    int notX = 5;
                    notX = win_Comp();
                    if (notX == 0)
                    {
                        if (pic5 == false)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else
                            if (pic == 1 && pic1 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox1.Image = O;
                                pic1 = true;
                            }
                            else if (pic == 3 && pic3 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox3.Image = O;
                                pic3 = true;
                            }
                            else if (pic == 4 && pic4 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox4.Image = O;
                                pic4 = true;
                            }
                            else if (pic == 5 && pic5 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox5.Image = O;
                                pic5 = true;
                            }
                            else if (pic == 6 && pic6 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox6.Image = O;
                                pic6 = true;
                            }
                            else if (pic == 2 && pic2 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox2.Image = O;
                                pic2 = true;
                            }
                            else if (pic == 8 && pic8 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox8.Image = O;
                                pic8 = true;
                            }
                            else if (pic == 9 && pic9 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox9.Image = O;
                                pic9 = true;
                            }
                            else if (win_ == false && comp_game() < 8)
                                goto a;
                    }
                    win();
                    all_click();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == true)
            {
                if (pic8 == false)
                {
                    if (X_or_O == false)
                    {
                        pictureBox8.Image = X;
                        X_or_O = true;
                    }
                    else
                    {
                        pictureBox8.Image = O;
                        X_or_O = false;
                    }
                    pic8 = true;
                }
                win();
                all_click();
            }
            else
            {
                if (pic8 == false)
                {
                    pictureBox8.Image = X;
                    pic8 = true;
                    win();
                a: int pic = rand.Next(9) + 1;
                    int notX = 5;
                    notX = win_Comp();
                    if (notX == 0)
                    {
                        if (pic5 == false)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else
                            if (pic == 1 && pic1 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox1.Image = O;
                                pic1 = true;
                            }
                            else if (pic == 3 && pic3 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox3.Image = O;
                                pic3 = true;
                            }
                            else if (pic == 4 && pic4 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox4.Image = O;
                                pic4 = true;
                            }
                            else if (pic == 5 && pic5 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox5.Image = O;
                                pic5 = true;
                            }
                            else if (pic == 6 && pic6 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox6.Image = O;
                                pic6 = true;
                            }
                            else if (pic == 7 && pic7 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox7.Image = O;
                                pic7 = true;
                            }
                            else if (pic == 2 && pic2 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox2.Image = O;
                                pic2 = true;
                            }
                            else if (pic == 9 && pic9 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox9.Image = O;
                                pic9 = true;
                            }
                            else if (win_ == false && comp_game() < 8)
                                goto a;
                    }
                    win();
                    all_click();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == true)
            {
                if (pic9 == false)
                {
                    if (X_or_O == false)
                    {
                        pictureBox9.Image = X;
                        X_or_O = true;
                    }
                    else
                    {
                        pictureBox9.Image = O;
                        X_or_O = false;
                    }
                    pic9 = true;
                }
                win();
                all_click();
            }
            else
            {
                if (pic9 == false)
                {
                    pictureBox9.Image = X;
                    pic9 = true;
                    win();
                a: int pic = rand.Next(9) + 1;
                    int notX = 5;
                    notX = win_Comp();
                    if (notX == 0)
                    {
                        if (pic5 == false)
                        {
                            pictureBox5.Image = O;
                            pic5 = true;
                        }
                        else
                            if (pic == 1 && pic1 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox1.Image = O;
                                pic1 = true;
                            }
                            else if (pic == 3 && pic3 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox3.Image = O;
                                pic3 = true;
                            }
                            else if (pic == 4 && pic4 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox4.Image = O;
                                pic4 = true;
                            }
                            else if (pic == 5 && pic5 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox5.Image = O;
                                pic5 = true;
                            }
                            else if (pic == 6 && pic6 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox6.Image = O;
                                pic6 = true;
                            }
                            else if (pic == 7 && pic7 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox7.Image = O;
                                pic7 = true;
                            }
                            else if (pic == 8 && pic8 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox8.Image = O;
                                pic8 = true;
                            }
                            else if (pic == 2 && pic2 == false && win_ == false && comp_game() < 8)
                            {
                                pictureBox2.Image = O;
                                pic2 = true;
                            }
                            else if (win_ == false && comp_game() < 8)
                                goto a;
                    }
                    win();
                    all_click();
                }
            }
        }

    // очистка игрового поля
        private void restart()
        {
            pic1 = false;
            pic2 = false;
            pic3 = false;
            pic4 = false;
            pic5 = false;
            pic6 = false;
            pic7 = false;
            pic8 = false;
            pic9 = false;
            X_or_O = false;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            win_ = false;
        }

        private void win()
        {
            if (pictureBox1.Image == X && pictureBox2.Image == X && pictureBox3.Image == X)
            {
                if (win_ == false)
                {
                    winX = winX + 1; ;
                    label1.Text = "X="+ winX.ToString();
                    MessageBox.Show("Крестики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }
            else if (pictureBox1.Image == O && pictureBox2.Image == O && pictureBox3.Image == O)
            {
                if (win_ == false)
                {
                    winO = winO + 1;
                    label2.Text ="O="+  winO.ToString();
                    MessageBox.Show("Нолики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }

            if (pictureBox4.Image == X && pictureBox5.Image == X && pictureBox6.Image == X)
            {
                if (win_ == false)
                {
                    winX = winX + 1;
                    label1.Text ="X="+ winX.ToString();
                    MessageBox.Show("Крестики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }
            else if (pictureBox4.Image == O && pictureBox5.Image == O && pictureBox6.Image == O)
            {
                if (win_ == false)
                {
                    winO = winO + 1;
                    label2.Text = "O="+ winO.ToString();
                    MessageBox.Show("Нолики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }

            if (pictureBox7.Image == X && pictureBox8.Image == X && pictureBox9.Image == X)
            {
                if (win_ == false)
                {
                    winX = winX + 1;
                    label1.Text = "X="+ winX.ToString();
                    MessageBox.Show("Крестики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }
            else if (pictureBox7.Image == O && pictureBox8.Image == O && pictureBox9.Image == O)
            {
                if (win_ == false)
                {
                    winO = winO + 1;
                    label2.Text = "O="+  winO.ToString();
                    MessageBox.Show("Нолики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }

            if (pictureBox1.Image == X && pictureBox4.Image == X && pictureBox7.Image == X)
            {
                if (win_ == false)
                {
                    winX = winX + 1;
                    label1.Text = "X="+ winX.ToString();
                    MessageBox.Show("Крестики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }
            else if (pictureBox1.Image == O && pictureBox4.Image == O && pictureBox7.Image == O)
            {
                if (win_ == false)
                {
                    winO = winO + 1;
                    label2.Text = "O="+ winO.ToString();
                    MessageBox.Show("Нолики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }

            if (pictureBox2.Image == X && pictureBox5.Image == X && pictureBox8.Image == X)
            {
                if (win_ == false)
                {
                    winX = winX + 1;
                    label1.Text = "X="+ winX.ToString();
                    MessageBox.Show("Крестики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }
            else if (pictureBox2.Image == O && pictureBox5.Image == O && pictureBox8.Image == O)
            {
                if (win_ == false)
                {
                    winO = winO + 1;
                    label2.Text = "O="+ winO.ToString();
                    MessageBox.Show("Нолики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }

            if (pictureBox3.Image == X && pictureBox6.Image == X && pictureBox9.Image == X)
            {
                if (win_ == false)
                {
                    winX = winX + 1;
                    label1.Text = "X="+ winX.ToString();
                    MessageBox.Show("Крестики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }
            else if (pictureBox3.Image == O && pictureBox6.Image == O && pictureBox9.Image == O)
            {
                if (win_ == false)
                {
                    winO = winO + 1;
                    label2.Text = "O="+ winO.ToString();
                    MessageBox.Show("Нолики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }

            if (pictureBox1.Image == X && pictureBox5.Image == X && pictureBox9.Image == X)
            {
                if (win_ == false)
                {
                    winX = winX + 1;
                    label1.Text = "X="+ winX.ToString();
                    MessageBox.Show("Крестики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }
            else if (pictureBox1.Image == O && pictureBox5.Image == O && pictureBox9.Image == O)
            {
                if (win_ == false)
                {
                    winO = winO + 1;
                    label2.Text = "O="+ winO.ToString();
                    MessageBox.Show("Нолики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }

            if (pictureBox3.Image == X && pictureBox5.Image == X && pictureBox7.Image == X)
            {
                if (win_ == false)
                {
                    winX = winX + 1;
                    label1.Text =  "X="+ winX.ToString();
                    MessageBox.Show("Крестики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }
            else if (pictureBox3.Image == O && pictureBox5.Image == O && pictureBox7.Image == O)
            {
                if (win_ == false)
                {
                    winO = winO + 1;
                    label2.Text = "O="+ winO.ToString();
                    MessageBox.Show("Нолики победили!", "Крестики-нолики");
                    win_ = true;
                    win_no_click();
                }
            }
        }

        private void all_click()
        {
            if (pic1 == true && pic2 == true && pic3 == true && pic4 == true && pic5 == true && pic6 == true && pic7 == true && pic8 == true && pic9 == true && win_ == false)
            {
                MessageBox.Show("Ничья!", "Крестики-нолики");
                win_no_click();
            }
        }


        private void win_no_click()
        {
            pic1 = true;
            pic2 = true;
            pic3 = true;
            pic4 = true;
            pic5 = true;
            pic6 = true;
            pic7 = true;
            pic8 = true;
            pic9 = true;
        }

        private void mult_p_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (mult_p_ToolStripMenuItem.Checked == false)
            {
                mult_p_ToolStripMenuItem.Checked = true;
                one_p_ToolStripMenuItem.Checked = false;
                restart();
            }
            else
            {
                mult_p_ToolStripMenuItem.Checked = false;
                one_p_ToolStripMenuItem.Checked = true;
                restart();
            }
        }

        private void one_p_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (one_p_ToolStripMenuItem.Checked == false)
            {
                one_p_ToolStripMenuItem.Checked = true;
                mult_p_ToolStripMenuItem.Checked = false;
                restart();
            }
            else
            {
                one_p_ToolStripMenuItem.Checked = false;
                mult_p_ToolStripMenuItem.Checked = true;
                restart();
            }
        }

        private int comp_game()
        {
            int picture_n;
            picture_n = 0;
            if (pic1 == true)
                picture_n += 1;
            if (pic2 == true)
                picture_n += 1;
            if (pic3 == true)
                picture_n += 1;
            if (pic4 == true)
                picture_n += 1;
            if (pic5 == true)
                picture_n += 1;
            if (pic6 == true)
                picture_n += 1;
            if (pic7 == true)
                picture_n += 1;
            if (pic8 == true)
                picture_n += 1;
            if (pic9 == true)
                picture_n += 1;
            return picture_n;
        }


        private int win_Comp()
        {
            if (comp_game() > 7)
                return 1;
            else if (pictureBox1.Image == O && pictureBox2.Image == O && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox4.Image == O && pictureBox5.Image == O && pic6 == false)
            {
                pictureBox6.Image = O;
                pic6 = true;
                return 1;
            }
            else if (pictureBox7.Image == O && pictureBox8.Image == O && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox2.Image == O && pictureBox3.Image == O && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox6.Image == O && pictureBox5.Image == O && pic4 == false)
            {
                pictureBox4.Image = O;
                pic4 = true;
                return 1;
            }
            else if (pictureBox9.Image == O && pictureBox8.Image == O && pic7 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else if (pictureBox1.Image == O && pictureBox3.Image == O && pic2 == false)
            {
                pictureBox2.Image = O;
                pic2 = true;
                return 1;
            }
            else if (pictureBox4.Image == O && pictureBox6.Image == O && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox7.Image == O && pictureBox9.Image == O && pic8 == false)
            {
                pictureBox8.Image = O;
                pic8 = true;
                return 1;
            }
            else if (pictureBox1.Image == O && pictureBox4.Image == O && pic7 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else if (pictureBox2.Image == O && pictureBox5.Image == O && pic8 == false)
            {
                pictureBox8.Image = O;
                pic8 = true;
                return 1;
            }
            else if (pictureBox3.Image == O && pictureBox6.Image == O && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox4.Image == O && pictureBox7.Image == O && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox8.Image == O && pictureBox5.Image == O && pic2 == false)
            {
                pictureBox2.Image = O;
                pic2 = true;
                return 1;
            }
            else if (pictureBox9.Image == O && pictureBox6.Image == O && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox1.Image == O && pictureBox7.Image == O && pic4 == false)
            {
                pictureBox4.Image = O;
                pic4 = true;
                return 1;
            }
            else if (pictureBox2.Image == O && pictureBox8.Image == O && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox3.Image == O && pictureBox9.Image == O && pic6 == false)
            {
                pictureBox6.Image = O;
                pic6 = true;
                return 1;
            }
            else if (pictureBox1.Image == O && pictureBox5.Image == O && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox5.Image == O && pictureBox9.Image == O && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox1.Image == O && pictureBox9.Image == O && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox3.Image == O && pictureBox7.Image == O && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox7.Image == O && pictureBox5.Image == O && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox3.Image == O && pictureBox5.Image == O && pic7 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else if (pictureBox1.Image == X && pictureBox2.Image == X && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox4.Image == X && pictureBox5.Image == X && pic6 == false)
            {
                pictureBox6.Image = O;
                pic6 = true;
                return 1;
            }
            else if (pictureBox7.Image == X && pictureBox8.Image == X && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox2.Image == X && pictureBox3.Image == X && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox6.Image == X && pictureBox5.Image == X && pic4 == false)
            {
                pictureBox4.Image = O;
                pic4 = true;
                return 1;
            }
            else if (pictureBox9.Image == X && pictureBox8.Image == X && pic7 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else if (pictureBox1.Image == X && pictureBox3.Image == X && pic2 == false)
            {
                pictureBox2.Image = O;
                pic2 = true;
                return 1;
            }
            else if (pictureBox4.Image == X && pictureBox6.Image == X && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox7.Image == X && pictureBox9.Image == X && pic8 == false)
            {
                pictureBox8.Image = O;
                pic8 = true;
                return 1;
            }
            else if (pictureBox1.Image == X && pictureBox4.Image == X && pic7 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else if (pictureBox2.Image == X && pictureBox5.Image == X && pic8 == false)
            {
                pictureBox8.Image = O;
                pic8 = true;
                return 1;
            }
            else if (pictureBox3.Image == X && pictureBox6.Image == X && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox4.Image == X && pictureBox7.Image == X && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox8.Image == X && pictureBox5.Image == X && pic2 == false)
            {
                pictureBox2.Image = O;
                pic2 = true;
                return 1;
            }
            else if (pictureBox9.Image == X && pictureBox6.Image == X && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox1.Image == X && pictureBox7.Image == X && pic4 == false)
            {
                pictureBox4.Image = O;
                pic4 = true;
                return 1;
            }
            else if (pictureBox2.Image == X && pictureBox8.Image == X && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox3.Image == X && pictureBox9.Image == X && pic6 == false)
            {
                pictureBox6.Image = O;
                pic6 = true;
                return 1;
            }
            else if (pictureBox1.Image == X && pictureBox5.Image == X && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox5.Image == X && pictureBox9.Image == X && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox1.Image == X && pictureBox9.Image == X && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox3.Image == X && pictureBox7.Image == X && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox7.Image == X && pictureBox5.Image == X && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox3.Image == X && pictureBox5.Image == X && pic7 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else if (pictureBox2.Image == X && pictureBox7.Image == X && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox3.Image == X && pictureBox8.Image == X && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox4.Image == X && pictureBox3.Image == X && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox2.Image == X && pictureBox9.Image == X && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox1.Image == X && pictureBox6.Image == X && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox1.Image == X && pictureBox8.Image == X && pic7 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else if (pictureBox4.Image == X && pictureBox3.Image == X && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox1.Image == X && pictureBox6.Image == X && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox7.Image == X && pictureBox6.Image == X && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox5.Image == X && pictureBox3.Image == X && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox7.Image == X && pictureBox5.Image == X && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox5.Image == X && pictureBox9.Image == X && pic7 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else if (pictureBox2.Image == O && pictureBox7.Image == O && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox3.Image == O && pictureBox8.Image == O && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox4.Image == O && pictureBox3.Image == O && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox2.Image == O && pictureBox9.Image == O && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox1.Image == O && pictureBox6.Image == O && pic3 == false)
            {
                pictureBox3.Image = O;
                pic3 = true;
                return 1;
            }
            else if (pictureBox1.Image == O && pictureBox8.Image == O && pic7 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else if (pictureBox4.Image == O && pictureBox3.Image == O && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox1.Image == O && pictureBox6.Image == O && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox7.Image == O && pictureBox6.Image == O && pic5 == false)
            {
                pictureBox5.Image = O;
                pic5 = true;
                return 1;
            }
            else if (pictureBox5.Image == O && pictureBox3.Image == O && pic1 == false)
            {
                pictureBox1.Image = O;
                pic1 = true;
                return 1;
            }
            else if (pictureBox7.Image == O && pictureBox5.Image == O && pic9 == false)
            {
                pictureBox9.Image = O;
                pic9 = true;
                return 1;
            }
            else if (pictureBox5.Image == O && pictureBox9.Image == O && pic5 == false)
            {
                pictureBox7.Image = O;
                pic7 = true;
                return 1;
            }
            else return 0;
        }

        private void button2_Click(object sender, EventArgs e)  {
            restart();
        }

        // помощь
        private void help_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help helpForm = new help();
            helpForm.ShowDialog();
        }

        // о программе
        private void about_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }

        // выход
        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else return;
        }

        // начать новую игру
        private void new_game_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            winX = 0;
            winO = 0;
            label1.Text = "";
            label2.Text = "";
            label1.Text = "X="+ winX.ToString();
            label2.Text += "O="+ winO.ToString();
            restart();
        }

        private void game_category_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
