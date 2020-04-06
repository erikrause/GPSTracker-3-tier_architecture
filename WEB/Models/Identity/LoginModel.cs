using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB.Models.Identity
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //public bool IsLegacy { get; set; }
        public bool IsPersistent { get; set; }
        //public bool ShouldLockout { get; set; }
    }
}