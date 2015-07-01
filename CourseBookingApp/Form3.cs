using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
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
            //add the contents of the textboxes to fileLinesList
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                DateTime dateResult;
                
                try
                {
                    dateResult = DateTime.ParseExact(textBox2.Text, "d'/'M'/'yyyy", CultureInfo.InvariantCulture); //new CultureInfo("en-IE")
                    Form1.fileLinesList.Add(textBox1.Text);
                    Form1.fileLinesList.Add(dateResult.ToShortDateString());
                    Form1.fileLinesList.Add(textBox3.Text);
                    Form1.fileLinesList.Add("FFFFFFFFFFFF");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Date");
                }
                    //Form1.fileLinesList.Add(textBox2.Text); //TODO: Add date validation
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //saving everything back into Form1.fileLines
            //TODO: really need to change whole course list management to use a class instead
            List<string> tempList = new List<string>();

            if (Form1.fileLines != null)
            {
                foreach (string line in Form1.fileLines)
                {
                    tempList.Add(line);
                }
            }
            if (Form1.fileLinesList.ElementAtOrDefault(0) != null)
            {
                foreach (string line in Form1.fileLinesList)
                {
                    tempList.Add(line);
                }
            }

            Form1.fileLines = tempList.ToArray();
        }
    }
}
