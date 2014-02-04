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

   
   public String StudentName { get; private set; }
        public String StudentGrade { get; private set; }


        public typingWindow()
        {
            InitializeComponent();
           
            button1.Enabled = true;
        }

        public void button1_Click(object sender, EventArgs e)
        {

            StudentGrade =this.mark.getTypedField ()  ;
            StudentName = this.name.getTypedField();

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
       
   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void typingArea1_Load(object sender, EventArgs e)
        {
            
        }

        private void typingArea2_Load(object sender, EventArgs e)
        {

        }

        private void typingWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
