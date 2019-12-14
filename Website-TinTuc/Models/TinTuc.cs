using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Website_TinTuc.Models
{
    public class TinTuc
    {
        [ScaffoldColumn(false)]
        [Key]
        public int Tin_ID { get; set; }
        [Required, StringLength(100), Display(Name = "ID")]
        public string NoiDung { get; set; }
        public string NgayGui { get; set; }
        public string HinhAnh { get; set; }
        public int? TGia_ID { get; set; }
        public virtual TacGia TacGia { get; set; }
    }
}