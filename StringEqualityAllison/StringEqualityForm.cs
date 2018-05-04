/*
 * Created by: Allison Cook
 * Created on: May the 4th, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program compares two strings to see if they're the same
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEqualityAllison
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
            //hiding label
            lblAnswer.Hide();
        }

        private bool StringsAreEqual(string string1, string string2)
        {
            //declare variable
            bool isEqual;

            //set the strings to upper case
            string1 = string1.ToUpper();
            string2 = string2.ToUpper();

            //check if the strings are equal
            if (string1 == string2)
            {
                //set the bool to true
                isEqual = true;
            }
            else
            {
                //set the bool to false
                isEqual = false;
            }

            //retrun the bool
            return isEqual;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //decalring variables
            string string1, string2;
            bool isEqual;
            //setting the text to variables
            string1 = txtString1.Text;
            string2 = txtString2.Text;

            //calling the function and setting the bool to isEqual
            isEqual = StringsAreEqual(string1, string2);

            //displaying the answer
            if (isEqual == true)
            {
                lblAnswer.Text = "The strings are equal";
            }
            else
            {
                lblAnswer.Text = "The strings are not equal";
            }

            //showing answer
            lblAnswer.Show();
        }
    }
}
