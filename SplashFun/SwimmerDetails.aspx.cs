using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using SplashFun.Models;

namespace SplashFun
{
    public partial class SwimmerDetails : System.Web.UI.Page
    {
        List<TimeRecord> times;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public IQueryable<Swimmer> SwimmerDetailsView_GetItem([QueryString("swimmerID")] int? swimmerId)
        {
           
            var db = new SplashFun.Models.SwimContext();
            IQueryable<Swimmer> query = db.Swimmers;
            if (swimmerId.HasValue)
            {
                query = query.Where(s => s.SwimmerID == swimmerId);
            }
            else
            {
                query = null;
            }
            return query;
        }

        public string FormatRow(string id)
        {
            if (Convert.ToInt32(id) % 2 == 0)
            {
                return "class='active'";
            }
            else
            {
                return "class='success'";
            }
        }

        public IQueryable GetDistanceValues()
        {
            var _db = new SwimContext();
            return _db.Distances;
        }

        public IQueryable GetStrokes()
        {
            var _db = new SwimContext();
            return _db.Strokes;
        }
        public void btnAddNewTime_Click(object sender, EventArgs e)
        {
            TextBox time = (TextBox)SwimmerDetailsView.FindControl("txtTime");
            Panel addNew = (Panel)SwimmerDetailsView.FindControl("pnlNewTime");
            DropDownList stroke = (DropDownList)SwimmerDetailsView.FindControl("drpStroke");
            DropDownList measure = (DropDownList)SwimmerDetailsView.FindControl("drpDistance");

            
            if (Request.QueryString["SwimmerID"] != null)
            {
                int sid = Convert.ToInt32(Request.QueryString["SwimmerID"]);
                var newTime = new TimeRecord();
                newTime.SwimmerID = sid;
                newTime.DistanceID = Convert.ToInt32(measure.SelectedValue);
                newTime.StrokeID = Convert.ToInt32(stroke.SelectedValue);
                newTime.Record = time.Text;
                using (SwimContext _db = new SwimContext())
                {
                    _db.TimeRecords.Add(newTime);
                    _db.SaveChanges();
                    Repeater repeaterTimes = SwimmerDetailsView.FindControl("repTimeRecords") as Repeater;
                    //repeaterTimes.DataSource = _db.TimeRecords.Where(t => t.Swimmer.SwimmerID == sid).ToList();
                    repeaterTimes.DataBind();
                }

                if (addNew != null)
                {
                    addNew.Visible = false;
                }
            }
           
            

            
        }

        protected void btnShowAddTime_Click(object sender, EventArgs e)
        {
            Panel addNew = (Panel)SwimmerDetailsView.FindControl("pnlNewTime");

            if (addNew != null)
            {
                addNew.Visible = true;
            }
        }

        public System.Collections.IEnumerable repTimeRecords_GetData([QueryString("swimmerID")] int? swimmerId)
        {
            var db = new SplashFun.Models.SwimContext();
            times = db.TimeRecords.Where(t => t.Swimmer.SwimmerID == swimmerId).ToList(); ;
            
            if (!IsPostBack)
            {
                Repeater repeaterTimes = SwimmerDetailsView.FindControl("repBestTimes") as Repeater;
                if (repeaterTimes != null)
                {
                    repeaterTimes.DataSource = times;
                    repeaterTimes.DataBind();
                }
            }

            return times;
        }
    }
}