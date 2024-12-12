using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MelodyHub
{
    public partial class Index : System.Web.UI.Page
        {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx");

            }

        }

        protected void BtnSalir_Click1(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}