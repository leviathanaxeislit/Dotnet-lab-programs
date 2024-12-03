using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace BankInterestService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
 
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double principal = Convert.ToDouble(txtPrincipal.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            double time = Convert.ToDouble(txtTime.Text);

            // Create a reference to the web service
            BankInterestService.Service1 service = new BankInterestService.Service1();
            double simpleInterest = service.CalculateSimpleInterest(principal, rate, time);

            // Display the result in the Simple Interest textbox
            txtInterest.Text = simpleInterest.ToString();
        }
    }
}
