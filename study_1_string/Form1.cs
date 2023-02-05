using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_string
{
    public partial class EX : Form
    {
        public EX()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sample, Test, Text
            string strText = lblText.Text;
            lblContain.Text = strText.Contains("Test").ToString();
            lblEquals.Text = strText.Equals("Test").ToString();
            lblLength.Text = strText.Length.ToString();
            lblReplace.Text = strText.Replace("Test", "I Can").ToString();

            string[] strSplit = strText.Split(',');
            lblSplit1.Text = strSplit[0].ToString();    //"Sample"
            lblSplit2.Text = strSplit[1].ToString().Trim();    //" Test"
            lblSplit3.Text = strSplit[2].ToString().TrimStart();    //" Text"

            lblSubstring.Text = strText.Substring(3, 5).ToString();
            lblToLower.Text = strText.ToLower().ToString();
            lblToUpper.Text = strText.ToUpper();
            lblTrim.Text = strText.Trim();
        }
    }
}
