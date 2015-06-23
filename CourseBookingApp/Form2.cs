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
        string[] fileLines;
        List<string> date = new List<string>();
        List<string> cost = new List<string>();
        List<string> bookings = new List<string>();

        ListBox listBox;
        string buttons;


        //public struct courseDetails
        //{
        //    public string name;
        //    public string date;
        //    public string bookings;
        //    public int price;
        //};

        //courseDetails[] courseArray = new courseDetails[] { };

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

            fileLines = lines;
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
            if (fileLines != null && listBox.SelectedIndex != -1) //check that user has selected a course in the list
                label2.Text = listBox.Text;
            else
                label2.Text = "No Course Selected";

            //TODO: need cleaner way to loop through all these, bit messy when we have a large amount of button rows 
            //Just testing functionality of max 2 rows for now

            //courseDetails course1 = new courseDetails(); //might use a struct to hold course info, use string arrays for now but will need to sort by date at some point

            bookings.Clear();
            for(int i = 0; i < fileLines.Length; i++)
            {
                if (fileLines[i] == label2.Text)
                {
                   date.Add(fileLines[i + 1]);
                   cost.Add(fileLines[i + 2]);
                   bookings.Add(fileLines[i + 3]);
                }
            }

            //buttons = fileLines[3];


            if (bookings.ElementAtOrDefault(0) != null)
            {
                buttons = bookings[0];

                label5.Visible = true;
                label6.Visible = true;

                label5.Text = date[0];
                label6.Text = cost[0];

                for (int i = 0; i < buttons.Length; i++)
                {
                    MyControlArray1.AddNewButton();
                    MyControlArray1[i].Text = (i + 1).ToString();
                    MyControlArray1[i].Left = ((i + 1) * 35);
                    if (buttons[i] == 'B')
                    {
                        MyControlArray1[i].BackColor = Color.Green;
                        MyControlArray1[i].Text = "B";
                    }
                }
            }

            //buttons = fileLines[7];

            if (bookings.ElementAtOrDefault(1) != null)
            {
                buttons = bookings[1];

                label7.Visible = true;
                label8.Visible = true;

                label7.Text = date[1];
                label8.Text = cost[1];

                for (int i = 0; i < buttons.Length; i++)
                {
                    MyControlArray2.AddNewButton();
                    MyControlArray2[i].Text = (i + 1).ToString();
                    MyControlArray2[i].Left = ((i + 1) * 35);
                    MyControlArray2[i].Top += 40;
                    if (buttons[i] == 'B')
                    {
                        MyControlArray2[i].BackColor = Color.Green;
                        MyControlArray2[i].Text = "B";
                    }
                }
            }
        }

    //    private void btnAdd_Click(object sender, EventArgs e)
    //    {
    //        // Call the AddNewButton method of MyControlArray.
    //        MyControlArray1.AddNewButton();
    //        // Change the BackColor property of the Button 0.
    //        MyControlArray1[0].BackColor = System.Drawing.Color.Red;
    //    }

    //    private void btnRemove_Click(object sender, EventArgs e)
    //    {
    //        // Call the Remove method of MyControlArray.
    //        MyControlArray1.Remove();
    //    }
    }
}
