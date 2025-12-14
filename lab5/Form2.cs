using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Class1.name;

        }
        
        Random r = new Random();
        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            pictureBox1.Left += r.Next(0, 10);

          if(pictureBox1.Left>= 1300 || pictureBox2.Left>=1300)
            {
                timer1.Enabled = false;
                button1.Enabled = false;

                if (pictureBox1.Left > pictureBox2.Left)
                {
                    toolStripStatusLabel1.Text =
                         Class1.name + toolStripStatusLabel1.Text;
                    Class1.winner = Class1.name;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Computer " +
                        toolStripStatusLabel1.Text;
                    Class1.winner = "Computer";
                }



            }
}
   

        private void timer1_Tick(object sender, EventArgs e)
        {   
            pictureBox2.Left += r.Next(0, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            button2.Enabled = false;

        }
    }
}
