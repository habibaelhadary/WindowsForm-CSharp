using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable
namespace EF2First.Models
{
    public class Author
    {
        [Key]
        public int Auth_id { get; set; }

        [Required, MaxLength(50)]
        public string name { get; set; }

        [Required]
        public int age { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [Required, StringLength(50)]
        public string password { get; set; }

        [Column(TypeName = "date")]
        public DateTime Joindate { get; set; }

        public virtual List<New> News { get; set; } = new List<New>();
        public override string ToString()
        {
            return $"{name}";
        }

    }
}
