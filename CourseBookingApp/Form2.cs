using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        //array to hold each row of buttons so we can loop through them
        ButtonArray[] buttonRows; 
        Control[] dateArray; 
        Control[] costArray; 

        //using custom class MyPrintPreviewDialog instead of PrintPreviewDialog
        //as the default class does not allow you to select a different printer
        private MyPrintPreviewDialog printPreviewDialog1 = new MyPrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        //declare a string to hold the entire document contents. 
        private string documentContents;

        //declare a variable to hold the portion of the document that 
        //is not printed. 
        private string stringToPrint;

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

            //associate the PrintPage event handler with the PrintPage event.
            printDocument1.PrintPage +=
                new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //check that user has selected a course in the list
            if (fileLines != null && listBox.SelectedIndex != -1) 
                label2.Text = listBox.Text;
            else
                label2.Text = "No Course Selected";

            //erase everything in bookings so we don't end up readding the same lines 
            //onto the end when we reopen the form
            bookings.Clear(); 

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

        private void button1_Click(object sender, EventArgs e)
        {
            String temp = "";

            //loop through all our buttons and if a button text is set to "B" for 
            //booked then we want to create a print 
            //out for that booking number
            for (int i = 0; i < buttonRows.Length; i++)
            {
                foreach (Control button in buttonRows[i])
                {
                    if (button.Text == "B")
                    {
                        temp += "BOOKING NUMBER: " + button.Tag.ToString() + " " + label2.Text 
                            + Environment.NewLine;
                        temp += "Date: " + dateArray[i].Text + Environment.NewLine;
                        temp += "Cost: " + costArray[i].Text + Environment.NewLine;
                        temp += "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
                        temp += Environment.NewLine + Environment.NewLine;

                    }
                }
            }

            //documentContents = string.Join(Environment.NewLine, Form1.fileLines);
            documentContents = temp;
            stringToPrint = documentContents;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            Font headerFont = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
             

            //sets the value of charactersOnPage to the number of characters  
            //of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, headerFont,
                e.MarginBounds.Size, format,
                out charactersOnPage, out linesPerPage);

            //draws the string within the bounds of the page
            e.Graphics.DrawString(stringToPrint, headerFont, Brushes.Black,
                e.MarginBounds, format);

            //remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            //check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            //if there are no more pages, reset the string to be printed. 
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }
    }
}
