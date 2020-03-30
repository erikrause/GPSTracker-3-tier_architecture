using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class Contract
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateLastChanged { get; set; }
        public byte[] Scan { get; set; }
        //public bool Arhived { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        //public Tariff Tariff { get; set; }     //сам добавил
    }
}
