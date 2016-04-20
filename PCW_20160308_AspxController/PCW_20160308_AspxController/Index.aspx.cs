using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCW_20160308_AspxController {

    public partial class Index : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {            

        }

        protected void PaginaUmClick(object sender, EventArgs e) {
            Response.Redirect("Pagina1.aspx");
        }

        protected void PaginaDoisClick(object sender, EventArgs e) {
            Response.Redirect("Pagina2.aspx");
        }

        protected void PaginaLoginClick(object sender, EventArgs e) {
            Response.Redirect("Login.aspx");
        }

    }

}