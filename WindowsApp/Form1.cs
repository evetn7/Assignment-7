using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            int value;

            bool res = int.TryParse(Value1.Text, out value);
            if (res == false)
            {
                Result.ForeColor = Color.Red;
                Result.ImageAlign = ContentAlignment.MiddleCenter;
                string Word = Regex.Replace("Value must be numeric and > 0.","(.{30})", "$1\n");

                Result.Text = Word;

            }
            else
            {
                //Runs the check for the second value also. Without it, program crashes if improper second number is inputted.
                res = int.TryParse(Value2.Text, out value);
                if (res == false)
                {
                    Result.ForeColor = Color.Red;
                    string Word = "Value must be numeric and > 0.";

                    Result.Text = Word;
                }
                else
                {
                    Result.Text = (Convert.ToInt32(Value1.Text) + Convert.ToInt32(Value2.Text)).ToString();
                    Result.ForeColor = Color.Yellow;
                }
            }

        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            int value;

            bool res = int.TryParse(Value1.Text, out value);
            if (res == false)
            {
                Result.ForeColor = Color.Red;
                string Word = "Value must be numeric and > 0.";

                Result.Text = Word;
            }
            else
            {
                //Runs the check for the second value also. Without it, program crashes if improper second number is inputted.
                res = int.TryParse(Value2.Text, out value);
                if (res == false)
                {
                    Result.ForeColor = Color.Red;
                    string Word = "Value must be numeric and > 0.";

                    Result.Text = Word;
                }
                else
                {
                    Result.ImageAlign = ContentAlignment.MiddleCenter;
                    //Adjusted the function so it would multiple instead of adding
                    Result.Text = (Convert.ToInt32(Value1.Text) * Convert.ToInt32(Value2.Text)).ToString();
                    Result.ForeColor = Color.Yellow;
                }
            }


        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Result.Text = null;
            Value1.Text = null;
            Value2.Text = null;
        }

        private void Value1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Value2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }
