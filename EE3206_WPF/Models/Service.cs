using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Models
{
    public class Service
    {
        [Key]
        public int ID { get; set; }

        [Column("Service_Name")]
        [Required]
        [MaxLength(50)]
        public string serviceName { get; set; }

        [Column("Price")]
        [Required]
        public int price { get; set; }

        [Column("Description")]
        [Required]
        public string description { get; set; }
    }
}
