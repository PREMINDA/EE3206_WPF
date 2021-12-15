using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Models
{
    class Appoinment
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        [Column("Appoinment_Date")]
        [Required]
        [MaxLength(20)]
        public string Date { get; set; }

        [Column("Appoinment_Time")]
        [Required]
        [MaxLength(20)]
        public string Time { get; set; }


        public ICollection<AppoiServices> AppoiServices { get; set; }
    }
}
