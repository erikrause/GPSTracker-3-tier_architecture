using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GPSTracker.DAL.Interfaces;

namespace WEB.Models
{
    public class Payment
    {
        public float Sum { get; set; }
        //public bool Archived { get; set; }
        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }

        //public DateTime DateTime { get; set; }       //сам доавил


    }
}
