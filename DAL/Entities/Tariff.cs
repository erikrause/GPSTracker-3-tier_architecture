using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GPSTracker.DAL.Interfaces;

namespace GPSTracker.DAL.Entities
{
    public class Tariff : IEntity
    {
        public int Id { get; set; }
        public bool Archived { get; set; }
        public string OBDInformation { get; set; }
    }
}
