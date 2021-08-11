using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webbanhang.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Moi dang nhap lai")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Moi nhap Password")]
        public string PassWord { set; get; }

        public bool RemenberMe { set; get; }
    }
}