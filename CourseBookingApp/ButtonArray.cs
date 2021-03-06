﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CourseBookingApp 
{
    class ButtonArray : System.Collections.CollectionBase //https://msdn.microsoft.com/en-us/library/aa289500(v=vs.71).aspx
    {
        private readonly System.Windows.Forms.Form HostForm;

        public System.Windows.Forms.Button AddNewButton()
        {
            // Create a new instance of the Button class.
            System.Windows.Forms.Button aButton = new
               System.Windows.Forms.Button();
            // Add the button to the collection's internal list.
            this.List.Add(aButton);
            // Add the button to the controls collection of the form 
            // referenced by the HostForm field.
            HostForm.Controls.Add(aButton);
            // Set intial properties for the button object.
            aButton.Top = 60;
            aButton.Left = 40;
            aButton.Width = 30;
            aButton.Height = 30;
            aButton.Tag = this.Count;
            aButton.Text = "Button " + this.Count.ToString();
            aButton.Click += new System.EventHandler(ClickHandler);
            return aButton;
        }

        public ButtonArray(System.Windows.Forms.Form host)
        {
            HostForm = host;
            //this.AddNewButton();
        }

        public System.Windows.Forms.Button this[int Index]
        {
            get
            {
                return (System.Windows.Forms.Button)this.List[Index];
            }
        }

        public void Remove()
        {
            // Check to be sure there is a button to remove.
            if (this.Count > 0)
            {
                // Remove the last button added to the array from the host form 
                // controls collection. Note the use of the indexer in accessing 
                // the array.
                HostForm.Controls.Remove(this[this.Count - 1]);
                this.List.RemoveAt(this.Count - 1);
            }
        }

        public void ClickHandler(Object sender, System.EventArgs e)
        {
            if (((System.Windows.Forms.Button)sender).BackColor == Color.Green)
            {
                ((System.Windows.Forms.Button)sender).BackColor = SystemColors.Control;
                ((System.Windows.Forms.Button)sender).Text = ((System.Windows.Forms.Button)sender).Tag.ToString();
            }
            else
            {
                ((System.Windows.Forms.Button)sender).BackColor = Color.Green;
                ((System.Windows.Forms.Button)sender).Text = "B";
            }         
        }
    }
}
