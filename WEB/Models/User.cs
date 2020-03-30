using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace WEB.Models
{
    public class User
    {

        [MaxLength(255)]
        public string UserName { get; set; }

        //[MaxLength(255)]
        public string PasswordHash { get; set; }
        public int ClientId { get; set; }

        public Client Client { get; set; }
        public bool Archived { get; set; }

        // public Tariff Tariff { get; set; }
    }
}
