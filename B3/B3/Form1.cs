using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            int w = simpleOpenGlControl1.Width;
            int h = simpleOpenGlControl1.Height;
            Gl.glViewport(0, 0, w, h);
            Glu.gluPerspective(90, w / h, 1, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Glu.gluLookAt(0, 0, 5, 0, 0, 1, 0, 1, 0);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glPushMatrix();


            Gl.glRotated(andgle, 0, 1, 0);
            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glColor3f(1,0,0);
            Gl.glVertex3f(-1,0,0);


            Gl.glColor3f(1, 0, 1);
            Gl.glVertex3f(1,0,0);


            Gl.glColor3f(1, 1, 0);
            Gl.glVertex3f(0, 1, 0);
            Gl.glEnd();

            Gl.glPopMatrix();
        }

        private double andgle = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            simpleOpenGlControl1.Invalidate();
            andgle += 10;
        }
    }
}
