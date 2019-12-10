using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using Website_TinTuc.Models;

namespace Website_TinTuc
{
    public partial class danhsach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<TinTuc> GetTinTuc([QueryString("id")] int? categoryId)
        {           
                var _db = new Website_TinTuc.Models.DinhNghiaTinTuc();
                IQueryable<TinTuc> query = _db.Tintucs;
                if (categoryId.HasValue && categoryId > 0)
                {
                    query = query.Where(p => p.TGia_ID == categoryId);
                }
                return query;           
        }
    }
}