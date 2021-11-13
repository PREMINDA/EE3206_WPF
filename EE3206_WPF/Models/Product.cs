using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Models
{
    class Product
    {
        [Key]
        public int ID { get; set; }

        [Column("Product_Name")]
        [Required]
        [MaxLength(50)]
        public string productName { get; set; }

        [Column("Price")]
        [Required]
        public int price { get; set; }

        [Column("Description")]
        [Required]
        public string description { get; set; }
    }
}
