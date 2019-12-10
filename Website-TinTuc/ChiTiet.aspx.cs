using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Website_TinTuc.Models;
using System.Web.ModelBinding;

namespace Website_TinTuc
{
    public partial class ChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<TinTuc> GetDetails([QueryString("bookID")] int? bookId)
        {
            var _db = new Website_TinTuc.Models.DinhNghiaTinTuc();
            IQueryable<TinTuc> query = _db.Tintucs;
            if (bookId.HasValue && bookId > 0)
            {
                query = query.Where(p => p.Tin_ID == bookId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}