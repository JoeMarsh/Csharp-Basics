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

        ButtonArray MyControlArray1;
        ButtonArray MyControlArray2;
        ButtonArray MyControlArray3;
        ButtonArray MyControlArray4;
        ButtonArray MyControlArray5;
        ButtonArray MyControlArray6;
        ButtonArray MyControlArray7;
        ButtonArray MyControlArray8;
        ButtonArray MyControlArray9;
        ButtonArray MyControlArray10;

        public Form2(string[] lines, ListBox list)
        {
            InitializeComponent();

            filelines = lines;
            listBox = list;

            MyControlArray1 = new ButtonArray(this);
            MyControlArray2 = new ButtonArray(this);
            MyControlArray3 = new ButtonArray(this);
            MyControlArray4 = new ButtonArray(this);
            MyControlArray5 = new ButtonArray(this);
            MyControlArray6 = new ButtonArray(this);
            MyControlArray7 = new ButtonArray(this);
            MyControlArray8 = new ButtonArray(this);
            MyControlArray9 = new ButtonArray(this);
            MyControlArray10 = new ButtonArray(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (filelines != null && listBox.SelectedIndex != -1) //check that user has selected a course in the list
                label2.Text = listBox.Text;
            else
                label2.Text = "No Course Selected";


            //todo: need a cleaner way than this of reading and writing to the list rather than breaking it up
            buttons = filelines[3].Trim('"');


            //todo: need a better way to generate all the buttons. just testing functionality for now
            for (int i = 0; i < buttons.Length; i++)
            {
                MyControlArray1.AddNewButton();
                MyControlArray1[i].Text = (i + 1).ToString();
                MyControlArray1[i].Left = ((i + 1) * 40);
                if (buttons[i] == 'B')
                {
                    MyControlArray1[i].BackColor = Color.Green;
                    MyControlArray1[i].Text = "B";
                }
            }

            buttons = filelines[7].Trim('"');

            for (int i = 0; i < buttons.Length; i++)
            {
                MyControlArray2.AddNewButton();
                MyControlArray2[i].Text = (i + 1).ToString();
                MyControlArray2[i].Left = ((i + 1) * 40);
                MyControlArray2[i].Top += 40;
                if (buttons[i] == 'B')
                {
                    MyControlArray2[i].BackColor = Color.Green;
                    MyControlArray2[i].Text = "B";
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Call the AddNewButton method of MyControlArray.
            MyControlArray1.AddNewButton();
            // Change the BackColor property of the Button 0.
            MyControlArray1[0].BackColor = System.Drawing.Color.Red;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Call the Remove method of MyControlArray.
            MyControlArray1.Remove();
        }
    }
}
