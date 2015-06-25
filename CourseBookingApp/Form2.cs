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
        List<int> nameIndex = new List<int>();
        List<string> name = new List<string>();
        List<string> date = new List<string>();
        List<string> cost = new List<string>();
        List<string> bookings = new List<string>();

        ListBox listBox;
        string buttons;

        //array of each row of buttons - see the ButtonArray.cs class
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

        ButtonArray[] buttonRows; //array to hold each row of buttons so we can loop through them
        Control[] dateArray; //array of date labels
        Control[] costArray; //array of cost labels

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

            buttonRows = new ButtonArray[] { MyControlArray1, MyControlArray2, MyControlArray3, 
                MyControlArray4, MyControlArray5, MyControlArray6, MyControlArray7, MyControlArray8,
                MyControlArray9, MyControlArray10 };

            dateArray = new Control[] { label5, label7, label9, label11,
                label13, label15, label17, label19, label21, label23 };

            costArray = new Control[] { label6, label8, label10, label12,
                label14, label16, label18, label20, label22, label24 };
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (fileLines != null && listBox.SelectedIndex != -1) //check that user has selected a course in the list
                label2.Text = listBox.Text;
            else
                label2.Text = "No Course Selected";

            bookings.Clear(); //erase everything in bookings so we don't add more lines to it if we reopen the form

            //loop through all lines and if any match the selected course add the name, date and cost
            //add them to the corresponding list. 
            for(int i = 0; i < fileLines.Length; i++) 
            {
                if (fileLines[i] == label2.Text)
                {
                   nameIndex.Add(i);
                   name.Add(fileLines[i]);
                   date.Add(fileLines[i + 1]);
                   cost.Add(fileLines[i + 2]);
                   bookings.Add(fileLines[i + 3]);
                }
            }

            //create and populate a row of 12 buttons for each course date and set them to booked/not booked
            for (int k = 0; k < 10; k++)
            {
                if (bookings.ElementAtOrDefault(k) != null)
                {
                    buttons = bookings[k];

                    dateArray[k].Visible = true;
                    costArray[k].Visible = true;

                    dateArray[k].Text = date[k];
                    costArray[k].Text = cost[k];

                    for (int i = 0; i < buttons.Length; i++)
                    {
                        //add button to the row and set its position
                        buttonRows[k].AddNewButton();
                        buttonRows[k][i].Text = (i + 1).ToString();
                        buttonRows[k][i].Left = ((i + 1) * 35);
                        buttonRows[k][i].Top = 50 * (k + 1);
                        //set the button to show 'B' and background colour green depending on 
                        //the booking status
                        if (buttons[i] == 'B')
                        {
                            buttonRows[k][i].BackColor = Color.Green;
                            buttonRows[k][i].Text = "B";
                        }
                    }
                    //setting top position of the date and cost labels here instead on the form designer
                    dateArray[k].Top = buttonRows[k][k].Top + 10; 
                    costArray[k].Top = buttonRows[k][k].Top + 10;
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: Just saving to static array Form1.fileLines for now.
            //might be better as a class to manage the data elements

            //put everything back into Form1.fileLines so we can save it to text file
            for (int k = 0; k < 10; k++)
            {
                if (bookings.ElementAtOrDefault(k) != null)
                {
                    StringBuilder stringBuilder = new StringBuilder(bookings[k]);

                    for (int i = 0; i < 12; i++)
                    {
                        if (buttonRows[k][i].Text != "B")
                            buttonRows[k][i].Text = "F";

                        stringBuilder[i] = Convert.ToChar(buttonRows[k][i].Text);
                    }
                    Form1.fileLines[nameIndex[k] + 3] = stringBuilder.ToString();
                }
            }
        }

    }
}
