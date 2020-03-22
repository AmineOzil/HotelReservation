using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace ClientApp
{
    public partial class rechercherChambre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }





        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ServiceHotel.WebService1SoapClient client = new ServiceHotel.WebService1SoapClient();
            String dates = depart.Value;
            String splitor = " to";
            String[] datesAR = dates.Split(splitor.ToCharArray());
            String checkIn = datesAR[0];
            String checkOut = datesAR[4];
            System.Diagnostics.Debug.WriteLine(checkIn + "aaand" + checkOut + "for the city "+ ville.Value+"one of the "+prixMax.Value);
            ClientApp.ServiceHotel.Hotel[] result = client.rechercherChambre(
                                                    ville.Value,
                                                    checkIn,
                                                    checkOut,
                                                    Convert.ToInt32(prixMin.Value),
                                                    Convert.ToInt32(prixMax.Value)
                                                 );
            System.Diagnostics.Debug.WriteLine("aya bele3 " + result.ElementAt(0).Chambres.ElementAt(3).Numero);
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(typeof(ClientApp.ServiceHotel.Hotel));
                serializer.Serialize(stringwriter, this);
                // Create the XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(stringwriter.ToString());
            }

        }
    }
}
