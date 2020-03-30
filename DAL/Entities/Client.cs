using GPSTracker.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSTracker.DAL.Entities
{
    public class Client : IEntity
    {
        //[ForeignKey("IndividualClient")]
        public int? IndividualClientId { get; set; }
        public virtual IndividualClient IndividualClient { get; set; }
        //[ForeignKey("LegalClient")]
        public int? LegalClientId { get; set; }
        public virtual LegalClient LegalClient { get; set; }
        public int Id { get; set; }
        public bool Archived { get; set; }


        //
        //public virtual ICollection<Payment> Payments { get; set; }
    }
}
