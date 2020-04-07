using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GPSTracker.DAL.Entities;

namespace WEB.Models
{
    public class Vehicle
    {
        [MaxLength(50)]
        public string RegNumber { get; set; }

        [MaxLength(50)]
        public string VIN { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(50)]
        public string Model { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(10)]
        public string Type { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(10)]
        public string Cetegory { get; set; }

        public int Year { get; set; }

        [MaxLength(50)]
        public string EngineModel { get; set; }

        [MaxLength(50)]
        public string Chassis { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(50)]
        public string Color { get; set; }

        public int Power { get; set; }

        public int TankCapacity { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(10)]
        public string EngineType { get; set; }

        public int MaxMass { get; set; }

        public int UnladenMass { get; set; }

        [MaxLength(50)]
        public string Manufacturer { get; set; }

        [Column(TypeName = "char")]
        [MaxLength(50)]
        public string Country { get; set; }

        //public bool Archived { get; set; }

        public Tracker Tracker { get; set; }

        public Client Client { get; set; }
        public int Id { get; set; }
        public bool Archived { get; set; }
    }
}
