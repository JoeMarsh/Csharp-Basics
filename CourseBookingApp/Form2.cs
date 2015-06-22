using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseBookingApp
{
    public partial class Form2 : Form
    {
        string[] filelines;
        ListBox listBox;

        public Form2(string[] lines, ListBox list)
        {
            InitializeComponent();

            filelines = lines;
            listBox = list;                            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (filelines != null && listBox.SelectedIndex != -1) //check that user has selected a course in the list
                label2.Text = listBox.Text;
            else
                label2.Text = "No Course Selected";
        }
    }
}
