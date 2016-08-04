using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SplashFun.Models;


namespace SplashFun
{
    public partial class SwimmerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Swimmer> GetSwimmers()
        {
            var db = new SplashFun.Models.SwimContext();
            IQueryable<Swimmer> query = db.Swimmers;
            return query;
        }

        protected void AddSwimmerButton_Click(object sender, EventArgs e)
        {
            //string query = "test.aspx";
            //string newWin = "window.open('" + query + "');";
            //ClientScript.RegisterStartupScript(this.GetType(), "pop", newWin, true);
            //Response.Redirect("~/Admin/AddSwimmer.aspx");
        }

        
    }
}