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
using System.Xml;

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"cars.xml");

            XmlTextReader xr = new XmlTextReader(sr);

            XmlDocument carCollectionDoc = new XmlDocument();

            carCollectionDoc.Load(xr);

            linkLabel1.Text = carCollectionDoc.InnerText;

            linkLabel2.Text = " First child node: " + carCollectionDoc.FirstChild.InnerText;

            linkLabel3.Text = " Second child node: " + carCollectionDoc.FirstChild.NextSibling.InnerText;

            XmlNode carcollection = carCollectionDoc.FirstChild.NextSibling;

            linkLabel4.Text = "Now that we have a reference to 'carcollection': " + carcollection.FirstChild.InnerText;

            linkLabel5.Text = "First child of carcollection: " + carcollection.FirstChild.InnerText;

            linkLabel6.Text = "First child of the first child of carcollection " + carcollection.FirstChild.FirstChild.InnerText;

            XmlNodeList carCollectionItems = carCollectionDoc.SelectNodes("carcollection/car");

            XmlNode make = carCollectionItems.Item(0).SelectSingleNode("make");

            linkLabel7.Text = "make.InnerText: " + make.InnerText;
        }
    }
}
