using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Models
{
    class Order
    {
        [Key]
        public int ID { get; set; }

        public User user { get; set; }

        public ICollection<OrderItem> orderItems { get; set; }
    }
}
