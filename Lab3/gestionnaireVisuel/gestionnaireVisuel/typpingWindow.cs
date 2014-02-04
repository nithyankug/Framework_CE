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
<<<<<<< HEAD
        private float mark;
=======

        public String StudentName { get; private set; }
        public String StudentGrade { get; private set; }
>>>>>>> ListView works

        public typpingWindow()
        {
            InitializeComponent();
           
            button1.Enabled = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // FIXME if( (this.textBox3 .Text)  !="")
  
=======
            StudentGrade = MarkTbx.Text;
            StudentName = nameTbx.Text;

>>>>>>> ListView works
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            button1.Enabled = ((this.nameTbx.Text != ""));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
