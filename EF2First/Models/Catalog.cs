using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable
namespace EF2First.Models
{
    public class Catalog
    {
        [Key]
        public int Ct_id { get; set; }

        [Required, MaxLength(50)]
        public string name { get; set; }

        [Required, StringLength(200)]
        public string description { get; set; }

        public virtual List<New> News { get; set; } = new List<New>();
        public override string ToString()
        {
            return $"{name}{Ct_id}";
        }
    }
}
