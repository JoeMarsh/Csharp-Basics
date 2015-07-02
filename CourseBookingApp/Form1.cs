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
        string filename;
        public static string[] fileLines;
        public static List<string> fileLinesList = new List<string>(); 
        List<string> courseNames = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
        }

        //TODO: Should create a class and subscribe all Forms to event to call this method
        //public void UpdateListMenu()
        //{
        //    for (int i = 0; i < fileLines.Length; i += 4)
        //    {
        //        courseNames.Add(fileLines[i]);  //add just the course titles into courseNames list                
        //    }

        //    courseNames = courseNames.Distinct().ToList<String>(); //remove any duplicate course titles

        //    listBox1.Items.Clear(); //clear the listbox so we dont add to the list if open file is used more than once

        //    foreach (string item in courseNames)
        //    {
        //        listBox1.Items.Add(item); //add the course titles to the listbox
        //    }              
        //}

        private void openToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";

            try
            {
                //opens file selection window
                if (theDialog.ShowDialog() == DialogResult.OK) 
                {
                    filename = theDialog.FileName;
                    if (Path.GetExtension(filename) == ".txt")
                    {
                        //read the opened file into fileLines
                        fileLines = File.ReadAllLines(filename, Encoding.Default); 
 
                        for (int i = 0; i < fileLines.Length; i++)
                        {
                            //remove '"' from beginning and end of each line
                            fileLines[i] = fileLines[i].Trim('"'); 
                        }

                        for (int i = 0; i < fileLines.Length; i += 4)
                        {
                            //add just the course titles into courseNames list 
                            courseNames.Add(fileLines[i]);                 
                        }

                        //remove any duplicate course titles
                        courseNames = courseNames.Distinct().ToList<String>();

                        //clear the listbox so we dont add to the list if open file 
                        //is used more than once
                        listBox1.Items.Clear(); 

                        foreach (string item in courseNames)
                        {
                            //add the course titles to the listbox
                            listBox1.Items.Add(item); 
                        }
                    }
                    else                    
                        MessageBox.Show("Wrong file format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                    MessageBox.Show("File open error or dialog cancelled - Error Code 002", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("File open error or dialog cancelled - Error Code 002", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.FormClosed += form3Closed;
            frm.Show();
        }

        void form3Closed(object sender, FormClosedEventArgs e)
        {
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); //opens save dialog window
            save.Title = "Save Text File";
            save.Filter = "TXT files|*.txt";
            //save.InitialDirectory = @"C:\Users\blue3\Documents\vsprojects\Csharp-Basics\CourseBookingApp";
            save.CreatePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //save.FileName = filename;
                    string[] tempStringArray = fileLines;
                    for (int i = 0; i < tempStringArray.Length; i++)
                    {
                        tempStringArray[i] = '"' + tempStringArray[i] + '"';
                    }

                    using (StreamWriter writer = new StreamWriter(save.OpenFile()))
                    {
                        for (int i = 0; i < tempStringArray.Length; i++)
                        {
                            writer.WriteLine(tempStringArray[i]);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("No file to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("File save error - Error 003", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", fileLines);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog newFile = new SaveFileDialog(); 
            newFile.Title = "New Save File";
            newFile.Filter = "TXT files|*.txt";
            //check that the user has the right file extension when creating a new file
            if (newFile.ShowDialog() == DialogResult.OK && (Path.GetExtension(newFile.FileName) == ".txt")) 
            {
                try
                {
                    File.Create(newFile.FileName);
                }
                catch (InvalidDataException f)
                {
                    MessageBox.Show("File incorrect format or missing or dialog cancelled - Error 001", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("File incorrect format or missing or dialog cancelled - Error 001", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }     
    }
}
