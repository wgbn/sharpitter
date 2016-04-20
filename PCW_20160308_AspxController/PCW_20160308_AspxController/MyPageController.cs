using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCW_20160308_AspxController {

    public class MyPageController : System.Web.UI.Page {

        public MyPageController() : base() {
            this.Load += MyPageController_Load;
        }

        private void MyPageController_Load(object sender, EventArgs e) {
            String param = Request.Params["par1"];

            if (param != null) {
                if (param != "OK") {
                    Response.Redirect("Erro.aspx");
                }
            }
        }
    }

}