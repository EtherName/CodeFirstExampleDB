using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Entities
{
    //[Table("TicketType", Schema = "dbo")]
    public class TicketType
    {
        public TicketType()
        {
            Tickets = new HashSet<Ticket>();
        }
        [Key]
        [Column("TicketTypeId")]
        [Required]
        public int Id { get; set; }
        [Column("Type")]
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(150)]
        public string Type { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }


    }
}
