using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB.Models.Identity
{
    public class RegisterModel
    {
        [Required]
        [DefaultValue("erkinkamilov@mail.ru")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }
        [Required]
        [DefaultValue("ProbAddres")]
        public string Address { get; set; }
        [Required]
        [DefaultValue("erikrause")]
        public string Name { get; set; }
    }
}