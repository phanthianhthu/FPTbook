using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanSach.Models.Data;
using System.ComponentModel.DataAnnotations;

namespace WebBanSach.Areas.Admin.Models
{
    public class LoginModel
    {
        //Call a LoginModel to equal with Admin in Models

        [Required(ErrorMessage = "You have not signed up yet")]
        [Display(Name ="Account")]
        public string TaiKhoan { get; set; }

        [Required(ErrorMessage = "You have not entered your password")]
        [Display(Name = "Password")]
        public string MatKhau { get; set; }

        [Display(Name = "Memorize")]
        public bool? GhiNho { get; set; }

        [Display(Name = "Full Name ")]
        public string HoTen { get; set; }

        [Display(Name = "Status")]
        public bool? TrangThai { get; set; }
    }
}