using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String inputOne
        {
            set 
            {
                textBox1.Text = value;
            }
        }
        public String inputTwo
        {
            set
            {
                textBox2.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();

            userControl21.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();

            userControl11.Hide();
        }
    }
}
