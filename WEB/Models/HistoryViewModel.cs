using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class HistoryViewModel : IEntityViewModel
    {
        public int Id { get; set; }
        public DbGeography Point { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public DateTime DateTime { get; set; }
        public float Speed { get; set; }
        public int VehicleId { get; set; }
        public VehicleViewModel Vehicle { get; set; }
    }
}
