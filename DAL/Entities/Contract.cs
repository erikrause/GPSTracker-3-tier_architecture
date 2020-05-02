using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GPSTracker.DAL.Interfaces;

namespace GPSTracker.DAL.Entities
{
    public class Contract : IEntity
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateLastChanged { get; set; }
        public byte[] Scan { get; set; }
        //public bool Arhived { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int Id { get; set; }
        public bool Archived { get; set; }

        //public Tariff Tariff { get; set; }     //сам добавил
    }
}
