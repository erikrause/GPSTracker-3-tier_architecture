using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WEB.Models.prob
{
    public class A
    {
        public int Id { get; set; }
        [ForeignKey("B")]
        public int BId { get; set; }
        public B B { get; set; }
    }
}