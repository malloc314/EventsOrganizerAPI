using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsOrganizer.Entities
{
    [Table("Events")]
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }

        [Required]
        [MaxLength(64)]
        public string Subiect { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        public int Limit { get; set; }

        public bool IsLimit { get; set; }

        public bool IsOnline { get; set; }

        public Guid AddressGuid { get; set; }


        public virtual Address Address { get; set; }
        public virtual List<Member> Members { get; set; }
    }
}
