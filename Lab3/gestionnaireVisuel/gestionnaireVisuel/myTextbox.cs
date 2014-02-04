using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionnaireVisuel
{
    class myTextbox:TextBox 
    {
        private String filigrane = "Click here to type";

        protected override void OnGotFocus(EventArgs e)
        {
            if (this.Text == "")
            {
                this.Text = this.filigrane;
            }
            else
            {
                this.Text = "";
            }

            base.OnGotFocus(e);
            
            
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
        }
    }
}
