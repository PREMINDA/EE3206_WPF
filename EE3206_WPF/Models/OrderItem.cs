using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Models
{
    class OrderItem
    {
        public int ID { get; set; }

        public int price { get; set; }

        public Product product { get; set; }
    }
}
