using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Website_TinTuc.Models
{
    public class DinhNghiaTinTuc : DbContext
    {
        public DinhNghiaTinTuc() : base("Website-TinTuc")
        { }
        public DbSet<TinTuc> Tintucs { get; set; }
        public DbSet<TacGia> Tacgias { get; set; }     
    }
}