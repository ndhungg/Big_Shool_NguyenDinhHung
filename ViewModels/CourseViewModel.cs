using BigSchool_NguyenDinhHung.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Globalization;

namespace BigSchool_NguyenDinhHung.ViewModels
{
    public class CourseViewModel
    {
        [Required (ErrorMessage = "Địa chỉ không được để trống")]
        [Display(Name = "Địa chỉ")]
        public string  Place { get; set; }

        [Required (ErrorMessage = "Ngày không được để trống")]
        [FutureDate]
        [Display(Name = "Ngày khởi tạo")]
        public string Date { get; set; }

        
        [Required(ErrorMessage = "Thời gian không được để trống")]
        [ValidTime]
        [Display(Name = "Thời gian")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Khóa học không được để trống")]
        [Display(Name = "Tên khóa học")]
        public byte  Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}