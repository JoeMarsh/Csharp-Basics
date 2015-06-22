using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseBookingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //open file menu
        {
            OpenFileDialog theDialog = new OpenFileDialog(); //opens file selection window
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\Users\blue20\Documents\vsprojects\Csharp-Basics\CourseBookingApp";

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                int j = 0;
                string filename = theDialog.FileName;
                string[] filelines = File.ReadAllLines(filename);
                for (int i = 0; i < filelines.Length; i++) //loop through each line in the opened file
                {
                    //add file text to the listbox but skip every 3rd and 4th item
                    if (j < 2)
                        listBox1.Items.Add(filelines[i].Trim('"'));
                    if (j == 3) //when we get to every 4th line in the file add a blank string to listbox and reset j to 0
                    {
                        listBox1.Items.Add("");
                        j = 0;
                    }
                    else
                        j++;
                }
            }
        }
        
    }
}
