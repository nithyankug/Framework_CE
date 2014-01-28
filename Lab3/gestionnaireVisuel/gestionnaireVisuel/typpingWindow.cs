using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionnaireVisuel
{
    public partial class typpingWindow : Form
    {
        public typpingWindow()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            button1.Enabled = ((this.textBox1.Text != ""));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
