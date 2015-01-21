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
            Send.Text = ResStrings.SendButton;
            Reset.Text = ResStrings.ResetButton;
            PageTitle.Text = ResStrings.PageTitle;
        }

        /// <summary>
        /// Disables form and calculates capitl letters
        /// </summary>
        protected void Send_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int upperCase = TextAnalyzer.GetNumberOfCapitals(Message.Text);
                Result.Text = String.Format("{0}: {1}", ResStrings.ResultMessage, upperCase.ToString());

                Message.Enabled = false;
                Result.Visible = true;
                
                Reset.Visible = true;
                Send.Visible = false;
            }
        }

        /// <summary>
        /// Resets form
        /// </summary>
        protected void Reset_Click(object sender, EventArgs e)
        {
            Message.Text = "";
            Message.Enabled = true;

            Result.Visible = false;
            Send.Visible = true;
        }
    }
}