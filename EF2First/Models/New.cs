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
   public class New
    {
        [Key]
        public int New_id { get; set; }

        [Required, StringLength(50)]
        public string title { get; set; }

        [StringLength(50)]
        public string bref { get; set; }

        [StringLength(100)]
        public string descr { get; set; }

        //[Column(TypeName = "time")]
        public TimeSpan time { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [ForeignKey("author")]
        public int Au_id { get; set; }

        [ForeignKey("cat")]
        public int Cat_id { get; set; }

        public virtual Catalog cat { get; set; }

        public virtual Author author { get; set; }

    }
}
