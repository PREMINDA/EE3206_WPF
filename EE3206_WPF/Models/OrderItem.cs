using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Models
{
    class OrderItem
    {
        [Key]
        public int ID { get; set; }

        [Column("Item_price")]
        public int price { get; set; }

        public Product product { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }


    }
}
