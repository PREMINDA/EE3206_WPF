using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Models
{
    class Appointment
    {
        [Key]
        public int ID { get; set; }



        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }


        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
