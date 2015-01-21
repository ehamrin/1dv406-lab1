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
        /// Disable input
        /// Calculate capital letters
        /// </summary>
        protected void Send_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int upperCase = TextAnalyzer.GetNumberOfCapitals(Message.Text);
                Message.Enabled = false;
                Result.Visible = true;
                Result.Text = String.Format("{0}: {1}", ResStrings.ResultMessage, upperCase.ToString());
                Send.Visible = false;
                Reset.Visible = true;
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
            Reset.Visible = false;
        }
    }
}