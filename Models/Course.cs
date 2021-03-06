using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_NguyenDinhHung.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }

        [Required]
        [StringLength(255, ErrorMessage ="Mã giảng viên không được dài quá 255 ký tự")]
        [Display(Name = "Mã giảng viên")]
        public string LecturerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }

        [Required]
        public byte CategoryId { get; set; }


    }
}

