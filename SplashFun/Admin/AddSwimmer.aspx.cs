using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SplashFun.Models;

namespace SplashFun.Admin
{
    public partial class AddSwimmer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable GetTeams()
        {
            var _db = new SwimContext();
            return _db.Teams;
        }

        protected void btnAddSwimmer_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            string avatar = "";
            //get avator
            string path = Server.MapPath("~/Images/avatars/");
            if (SwimmerImage.FileName.Length > 0)
            {
                String fileExtension = System.IO.Path.GetExtension(SwimmerImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
                if (fileOK)
                {
                    try
                    {
                        // Save to Images folder.
                        SwimmerImage.PostedFile.SaveAs(path + SwimmerImage.FileName);
                        avatar = SwimmerImage.FileName;
                    }
                    catch (Exception ex)
                    {
                        //LabelAddStatus.Text = ex.Message;
                    }
                }
            }
            else
            {
                avatar = "holder.png";
            }
            

            var newSwimmer = new Swimmer();
            newSwimmer.FirstName = txtFirstName.Text;
            newSwimmer.LastName = txtLastName.Text;
            newSwimmer.TeamID = Convert.ToInt32(drpTeam.SelectedValue);
            newSwimmer.Gender = drpGender.SelectedValue;
            newSwimmer.Age = Convert.ToInt32(txtAge.Text);
            newSwimmer.Avatar = avatar;

            using (SwimContext _db = new SwimContext())
            {
                _db.Swimmers.Add(newSwimmer);
                _db.SaveChanges();
            }

            Response.Redirect("~/SwimmerList.aspx");
        }
    }
}