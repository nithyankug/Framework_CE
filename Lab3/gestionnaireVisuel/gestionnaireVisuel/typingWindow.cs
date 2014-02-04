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
    public partial class typingWindow : Form
    {
<<<<<<< HEAD
        private float mark;
=======

        public String StudentName { get; private set; }
        public String StudentGrade { get; private set; }
>>>>>>> ListView works

        public typingWindow()
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
<<<<<<< HEAD:Lab3/gestionnaireVisuel/gestionnaireVisuel/typpingWindow.cs
            button1.Enabled = ((this.nameTbx.Text != ""));
=======
           // button1.Enabled = ((this.textBox1.Text != ""));
            
>>>>>>> update:Lab3/gestionnaireVisuel/gestionnaireVisuel/typingWindow.cs
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void typingArea1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
