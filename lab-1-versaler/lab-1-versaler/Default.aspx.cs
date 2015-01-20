using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_1_versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Determines state of button and calculates/resets form
        /// </summary>
        protected void Send_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (Send.Text == ResStrings.SendButton)
                {
                    int upperCase = TextAnalyzer.GetNumberOfCapitals(Message.Text);
                    Message.Enabled = false;
                    Result.Visible = true;
                    Result.Text = String.Format("{0}: {1}", ResStrings.ResultMessage, upperCase.ToString());
                    Send.Text = ResStrings.ResetButton;
                }
                else
                { 
                    Message.Text = "";
                    Send.Text = ResStrings.SendButton;
                    Message.Enabled = true;
                    Result.Visible = false;

                }
            }
        }
    }
}