using GPSTracker.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class Client
    {
        //[ForeignKey("IndividualClient")]
        public int? IndividualClientId { get; set; }
        public virtual IndividualClientViewModel IndividualClient { get; set; }
        //[ForeignKey("LegalClient")]
        public int? LegalClientId { get; set; }
        public virtual LegalClientViewModel LegalClient { get; set; }
        public int Id { get; set; }
        public bool Archived { get; set; }


        //
        //public virtual ICollection<Payment> Payments { get; set; }
    }
}
