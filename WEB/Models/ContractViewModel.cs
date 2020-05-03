using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class ContractViewModel : IEntityViewModel
    {
        [DisplayFormat(DataFormatString = "{0:dd'.'MM'.'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd'.'MM'.'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateLastChanged { get; set; }
        public byte[] Scan { get; set; }
        //public bool Arhived { get; set; }
        public int ClientId { get; set; }
        public int Id { get; set; }

        //public Tariff Tariff { get; set; }     //сам добавил
    }
}
