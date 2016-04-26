using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Entities
{
    //[Table("Ticket", Schema ="dbo")]
    public class Ticket
    {
        [Key]
        [Column("TicketId")]
        [Required]
        public int Id { get; set; }
        //[Column("TicketTypeId")]
        //[Required]
        //public int TypeId { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual TicketType TicketType { get; set; }
    }
}
