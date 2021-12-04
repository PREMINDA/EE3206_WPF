using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Column("Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Column("Email")]
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Column("TelephoneNumber")]
        [Required]
        [MaxLength(13)]
        public string TelNum { get; set; }
        [Column("Password")]
        [Required]
        public string Password { get; set; }
    }
}
