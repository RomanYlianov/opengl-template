using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_02_YLIANOV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            answer.Text = GetAnswer() + "Вы очень усердны";
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
        }


        void clear()
        {
            answer.Text ="Ваш ответ: "; 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }
        private String GetAnswer()
        {
            return "Ваш ответ: ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answer.Text = GetAnswer() + "очень жаль, что вы безразлично к этому";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x_l.Text = "x " + e.X.ToString();
            y_l.Text = "y " + e.Y.ToString();

            var location = this.Location;
            
            
            if (e.X > 37 && e.X < 37+75 && e.Y > 197 && e.Y < 197+23)
            {
                int w_width = this.Width; int w_height = this.Height;
                Random r = new Random();
                w_width += r.Next(-100, 100); w_height += r.Next(-100, 100);
                if (location.X < 0 || location.X > ( w_width - this.Width / 2) || location.Y < 0 || location.Y > (w_height - this.Height / 2))
                {
                    location.X = this.Width / 2;
                    location.Y = this.Height / 2;
                }

                this.Location = location;
            }
        }

   

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Text);

        }
    }
}
