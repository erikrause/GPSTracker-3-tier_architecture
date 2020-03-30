using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB.Models
{
    public class LegalClient
    {
        //[Key]
        //[ForeignKey("Client")]
        //public override int Id { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(255)]
        public string SecondName { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(255)]
        public string PatrName { get; set; }

        [MaxLength(50)]
        public string INN { get; set; }

        [MaxLength(50)]
        public string KPP { get; set; }

        [MaxLength(255)]
        public string Adress { get; set; }

        //public bool Archived { get; set; }

    }
}
