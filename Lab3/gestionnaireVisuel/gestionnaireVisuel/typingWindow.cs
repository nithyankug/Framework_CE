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
        public bool validTyping { get; private set; } 

        public typingWindow()
        {
            InitializeComponent();
           
            insertButton.Enabled = true;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            String recupName = this.name.getTypedField();
            double recupMark=-1;
            bool validMark = double.TryParse(this.mark.getTypedField(),out recupMark);

            if ((recupMark <= 20) && (recupMark >= 0) && (recupName != "") && (validMark) && (recupName != "Click here to type"))
            {
                StudentGrade = this.mark.getTypedField();
                StudentName = this.name.getTypedField();
                validTyping = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Invalid name or mark, try again please ...");
            }
            
        }

       

        private void typingArea1_Load(object sender, EventArgs e)
        {
           
        }

        private void typingArea2_Load(object sender, EventArgs e)
        {

        }

        private void typingWindow_Load(object sender, EventArgs e)
        {
            this.name.setFieldLabel("Name");
            this.mark.setFieldLabel("Mark");
        }
    }
}
