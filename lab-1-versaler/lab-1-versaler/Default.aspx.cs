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
            if (!IsPostBack) {
                Send.Text = Strings.SendButton;
            }
        }

        /// <summary>
        /// Determines state of button and calculates/resets form
        /// </summary>
        protected void Send_Click(object sender, EventArgs e)
        {
            if(Send.Text == Strings.SendButton)
            {
                int upperCase = TextAnalyzer.GetNumberOfCapitals(Message.Text);
                Message.Enabled = false;
                Result.Visible = true;
                Result.Text = String.Format(Strings.ResultMessage, upperCase.ToString());
                Send.Text = Strings.ResetButton;
            }else
            {
                Result.Visible = false;
                Message.Text = "";
                Send.Text = Strings.SendButton;
                Message.Enabled = true;

            }
        }
    }
}