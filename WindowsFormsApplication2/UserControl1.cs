using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var textBox1 = this.textBox1.Text;
            var textBox2 = this.textBox2.Text;

            //Parent
            var parent = this.Parent as Form1;

            parent.inputOne = textBox1;
            parent.inputTwo = textBox2;

        }
    }
}
