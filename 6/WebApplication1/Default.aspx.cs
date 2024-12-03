using System;
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

public partial class _Default : System.Web.UI.Page
{

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string tData = args.Value.ToString().Trim(); args.IsValid = false;
        if (tData.Length < 7 || tData.Length > 20) return;

        int charCnt = 0; int numCnt = 0;

        foreach (char x in tData)
        {
            if (x >= 'A' && x <= 'Z') charCnt++;
            if (x >= '0' && x <= '9') numCnt++;
        }
        if (charCnt < 1 || numCnt < 1) return; args.IsValid = true;
    }
}
