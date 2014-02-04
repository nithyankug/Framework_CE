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

    public partial class Form1 : Form
    {

        private List<String> _list;

        public Form1()
        {
            InitializeComponent();
            _list = new List<string>();
            myDisplay();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myDisplay()
        {
            // Variable declaration
           


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
            typpingWindow addStudent = new typpingWindow();
            String str;

            addStudent.ShowDialog();

            
            str = addStudent.StudentName + "  -  " + addStudent.StudentGrade;
            _list.Add(str);
            //listView1.Items.Add(str);
            refreshListView();
        }
    }



}
