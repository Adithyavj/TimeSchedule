using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class LoginModel
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int RememberMe { get; set; }
    }
}