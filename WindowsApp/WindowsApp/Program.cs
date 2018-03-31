/*
 Create a Windows application that contains two textboxes and three buttons.  The textboxes should be used to allow the user to input two positive numeric values. 
 The buttons should be labeled Add and Multiply and Reset. 
 Create event-handler methods that retrieve the values, perform the calculations, and display the result of the calculations on a label.  
 The result label should initially be set to be invisible with a font color of yellow. 
 If invalid data is entered, change the font color to red on the result label and display a message saying “Value must be numeric and > 0.” 
 When the final answer is displayed, the font color should be yellow.  Additional labels will be needed for the textboxes captions. Do not allow non-numeric characters to be entered. 
 Invoke the TryParse() method to retrieve he values.  All controls involved in program statements should be named.  Right justify values in the textbox.*/


using System;
using System.Windows.Forms;

namespace WindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
