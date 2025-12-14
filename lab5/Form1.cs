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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.name = txtname.Text;


            Form2 fc = new Form2();
            this.Hide();
            fc.ShowDialog(); // or fc.show
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
