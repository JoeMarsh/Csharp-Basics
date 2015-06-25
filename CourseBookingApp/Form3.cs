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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add the contents of the textboxes to fileLinesList          
            Form1.fileLinesList.Add(textBox1.Text);
            Form1.fileLinesList.Add(textBox2.Text);
            Form1.fileLinesList.Add(textBox3.Text);
            Form1.fileLinesList.Add("FFFFFFFFFFFF");
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //saving everything back into Form1.fileLines
            //TODO: really need to change whole course list management to use a class instead
            List<string> tempList = new List<string>();

            foreach(string line in Form1.fileLines)
            {
                tempList.Add(line);
            }
            foreach (string line in Form1.fileLinesList)
            {
                tempList.Add(line);
            }

            Form1.fileLines = tempList.ToArray();
        }
    }
}
