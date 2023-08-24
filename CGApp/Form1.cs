using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace CGApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            display.InitializeContexts();
        }

        double rotateAngle = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE |
            Glut.GLUT_DEPTH);
            // очистка окна
            Gl.glClearColor(255, 255, 255, 1);
            // установка порта вывода в соответствии с размерами элемента anT
            Gl.glViewport(0, 0, display.Width, display.Height);
            // настройка проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)display.Width / (float)display.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3ub(255, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -6);
            Gl.glRotated(45, 1, 1, 0);
            // рисуем сферу с помощью библиотеки FreeGLUT
            Glut.glutWireSphere(2, 32, 32);
            Gl.glPopMatrix();
            Gl.glFlush();
            display.Invalidate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
