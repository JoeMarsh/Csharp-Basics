﻿using System;
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

        string[] filelines;

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
                filelines = File.ReadAllLines(filename);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //check that a file has been open and listbox1 index is not set to -1. Otherwise show an error message.
            if (filelines != null && listBox1.SelectedIndex != -1)
            {
                Form2 frm = new Form2(filelines, listBox1); //pass filelines and the currently selected listbox index to Form2 so we can display the selected course
                frm.Show();
            }
            else if (filelines == null)
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
            Form2 frm = new Form2(filelines, listBox1); //pass filelines and the currently selected listbox index to Form2 so we can display the selected course
            frm.Show();
        }


        
    }
}