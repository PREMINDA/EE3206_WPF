using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Models
{
    public class AppoiServices
    {
        [Key]
        public int ID { get; set; }


        [ForeignKey("Service")]
        public int ServiceID { get; set; }
        public virtual Service Service { get; set; }
    }
}
