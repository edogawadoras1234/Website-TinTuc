using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Website_TinTuc.Models
{
    public class TacGia
    {
        [ScaffoldColumn(false)]
        [Key]
        public int TGia_ID { get; set; }
        [Required, StringLength(100), Display(Name = "Ten")]
        public string TenTG { get; set; }
        public string Email { get; set; }
        public virtual ICollection<TinTuc> Tintucs { get; set; }
    }
}