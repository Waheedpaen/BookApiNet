using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntitiesClasses.Entities;

public class Message
{
    [Key]
    public int  Id { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now;
    [ForeignKey("Sender")]
    public int SenderId { get; set; }
    [ForeignKey("Receiver")]

    public int ReceiverId { get; set; }

    // Navigation properties
    public virtual User? Sender { get; set; }
    public virtual User? Receiver { get; set; }
 
}
