using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Website_TinTuc.Models;

namespace Website_TinTuc
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<TacGia> GetCategories()
        {
            var _db = new Website_TinTuc.Models.DinhNghiaTinTuc();
            IQueryable<TacGia> query = _db.Tacgias;
            return query;
        }
    }
}