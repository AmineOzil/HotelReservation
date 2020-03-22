using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientApplication
{
    public partial class rechercherChambre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            String dates = depart.Value;
            String splitor = "to";
            String[] datesAR = dates.Split(splitor.ToCharArray());
            String checkIn = datesAR[0];
            String checkOut = datesAR[1];
            System.Diagnostics.Debug.WriteLine(checkIn + " aaand " + checkOut);
            String result = client.rechercherChambre(
                                                    ville.Value,
                                                    checkIn,
                                                    checkOut,
                                                    Convert.ToInt32(prixMin.Value),
                                                    Convert.ToInt32(prixMax.Value)
                                                 ).ToString();
        }
    }
} 