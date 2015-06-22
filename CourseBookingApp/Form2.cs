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
        string buttons;

        public Form2(string[] lines, ListBox list)
        {
            InitializeComponent();

            filelines = lines;
            listBox = list;                            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //if (filelines != null && listBox.SelectedIndex != -1) //check that user has selected a course in the list
            //    label2.Text = listBox.Text;
            //else
            //    label2.Text = "No Course Selected";

            //todo: need a cleaner way than this of reading and writing to the list rather than breaking it up
            buttons = filelines[3].Trim('"');


            //todo: set a loop to go through all possible buttons. just testing functionality for now
            if (buttons[0] == 'B')
            {
                button1.BackColor = Color.Green;
                button1.Text = "B";
            }
            else
            {
                button1.BackColor = Color.Gray;
                button1.Text = "1";
            }

            if (buttons[1] == 'B')
            {
                button2.BackColor = Color.Green;
                button2.Text = "B";
            }
            else
            {
                button2.BackColor = Color.Gray;
                button2.Text = "1";
            }

            if (buttons[2] == 'B')
            {
                button3.BackColor = Color.Green;
                button3.Text = "B";
            }
            else
            {
                button3.BackColor = Color.Gray;
                button3.Text = "1";
            }



        }
    }
}
