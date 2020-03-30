﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB.Models
{
    public class IndividualClient
    {
        //[Key]
        //[ForeignKey("Client")]
        //public int Id { get; set;}

        [Column(TypeName = "char")]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(255)]
        public string SurName { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(255)]
        public string PatrName { get; set; }

        [MaxLength(255)]
        public string Adress { get; set; }

        [MaxLength(50)]
        public string PassSeries { get; set; }

        [MaxLength(50)]
        public string PassNum;

        [MaxLength(255)]
        public string PassissueOrg { get; set; }

        public DateTime DateTime { get; set; }

        //public bool Archived { get; set; }

        // FK
        //public virtual Client Client { get; set; }
    }
}