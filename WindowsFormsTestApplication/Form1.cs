using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            if (this.textBoxName.Text != string.Empty)
                MessageBox.Show("Hello " + this.textBoxName.Text);
            else
            {
                MessageBox.Show("Enter your name!");
                this.textBoxName.Focus();
            }
        }
    }
}
