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

    public partial class mainForm : Form
    {
         private List<String> _list;
        public mainForm()
        {
    
            InitializeComponent();
            _list = new List<string>();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e){
         }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
    typingWindow addStudent = new typingWindow();
     //   {
            // Variable declaration
 // addStudent .         


        }

        
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void refreshListView()
        {
            listView1.Clear();
            foreach (String s in _list)
            {
                listView1.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String str;
            typingWindow addStudent = new typingWindow();


            addStudent.ShowDialog();

            str = addStudent.StudentName + "  -  " + addStudent.StudentGrade;
            _list.Add(str);
            //listView1.Items.Add(str);
            refreshListView();
        }
   
    }


}
