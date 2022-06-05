using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_NguyenDinhHung.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required (ErrorMessage = "Mã khóa học không được để trống")]
        [StringLength(255 , ErrorMessage ="Mã thể loại không thể dài quá 255 ký tự")]
        [Display(Name = "Mã khóa học")]
        public string Name { get; set;}
    }
}