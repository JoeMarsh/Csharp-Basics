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

        string[] fileLines;
        List<string> courseNames = new List<string>();      

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //open file menu
        {
            OpenFileDialog theDialog = new OpenFileDialog(); //opens file selection window
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\Users\blue20\Documents\vsprojects\Csharp-Basics\CourseBookingApp";

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = theDialog.FileName;
                fileLines = File.ReadAllLines(filename); // read the opened file into fileLines
                for (int i = 0; i < fileLines.Length; i++)
                {
                    fileLines[i] = fileLines[i].Trim('"'); //remove " from beginning and end of each line
                }

                for (int i = 0; i < fileLines.Length; i += 4)
                {
                    courseNames.Add(fileLines[i]);  //add just the course titles into courseNames list                
                }

                courseNames = courseNames.Distinct().ToList<String>(); //remove any duplicate course titles
                
                listBox1.Items.Clear(); //clear the listbox so we dont add to the list if open file is used more than once

                foreach (string item in courseNames)
                {
                    listBox1.Items.Add(item); //add the course titles to the listbox
                }              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check that a file has been open and listbox1 index is not set to -1. Otherwise show an error message.
            if (fileLines != null && listBox1.SelectedIndex != -1)
            {
                Form2 frm = new Form2(fileLines, listBox1); //pass filelines and the currently selected listbox index to Form2 so we can display the selected course
                frm.Show();
            }
            else if (fileLines == null)
            {
                MessageBox.Show("Unable to load course, no course file opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Unable to load course, no course selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Rectangle selectedItemRectangle = listBox1.GetItemRectangle(listBox1.SelectedIndex);
                if (selectedItemRectangle.Contains(listBox1.PointToClient(Cursor.Position))) //check that mouse cursor is actually over a listBox1 item so we dont open Form2 window with a blank selection when user double clicks
                {
                    Form2 frm = new Form2(fileLines, listBox1); //pass filelines and the currently selected listbox index to Form2 so we can display the selected course
                    frm.Show();
                }
            }
        }        
    }
}
