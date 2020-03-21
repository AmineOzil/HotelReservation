using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class rechercher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*            System.Windows.Forms.MessageBox.Show("Date : " + this.Calendar2.SelectedDate.ToShortDateString());
             *            System.Windows.Forms.MessageBox.Show("Date : " + this.Calendar1.SelectedDate.ToShortDateString());
            */
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {

            


        }
        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < Convert.ToDateTime(DateTime.Now.ToString()))
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Gray;
            }


        }
    }



}