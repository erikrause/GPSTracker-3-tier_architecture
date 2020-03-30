using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Spatial;
using GPSTracker.DAL.Interfaces;

namespace GPSTracker.DAL.Entities
{
    public class History : IEntity
    {
        public DbGeography Point { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public DateTime DateTime { get; set; }
        public float Speed { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int Id { get; set; }
        public bool Archived { get; set; }
    }
}
