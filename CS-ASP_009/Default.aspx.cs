using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_009
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int i = 5;
            int j = 6;
            int result = i + j;
            // int result = i - j;
            // int result = i * j;
            // int result = i / j;

            /* 
            i = i + 1;
            i += 1;
            i++;
            i--;
             */

            // int myInteger = (5 + 1) * 7;
            // resultsLabel.Text = myInteger.ToString();

            //double myDouble = 5.5;
            //int myInt = 7;

            //int myResult = (int)myDouble + myInt;

            int firstNumber = 2000000000;
            int secondNumber = 2000000000;
            long resultNumber;

            checked
            {
                resultNumber = firstNumber * secondNumber;
            }

            resultsLabel.Text = resultNumber.ToString();

        }
    }
}