using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionnaireVisuel
{
    public partial class typingArea : UserControl
    {
        public typingArea()
        {
            InitializeComponent();
            this.myTypingField.Text  = "Click here to type";
        }

        public void setFieldLabel(String nameToSet)
        {
            this.fieldName.Text = nameToSet;
        }

       /* public void setNameTextBox(String nameToSet)
        {
            this.myTypingField.Name = nameToSet;
        }
        */

        private void fieldName_Click(object h,EventArgs e)
        {
        }

        private void myTypingField_TextChanged(object sender, EventArgs e)
        {

        }

        public String getTypedField()
        {
            return this.myTypingField.Text;
        }


        public void setHintTextBox(String msgToSet)
        {
            this.myTypingField.Text  = msgToSet;
        }
        

        
    }
}
