using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class TrackerViewModel : IEntityViewModel
    {
        public int Id { get; set; }
        public int Frequency { get; set; }
        public float Sensivity { get; set; }
        public int Accuracy { get; set; }
        public int StandbyTime { get; set; }
        public float dimX { get; set; }
        public float dimY { get; set; }
        public float dimZ { get; set; }
        public float Weight { get; set; }
        //public bool Archived { get; set; }

    }
}
