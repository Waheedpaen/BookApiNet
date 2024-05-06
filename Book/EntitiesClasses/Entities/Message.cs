using Microsoft.AspNetCore.Http;
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
    public byte[] ? ImageData { get; set; }// i want save it by byte method 
    public string? FileNameAudio { get; set; }
    public string? FilePathAudio { get; set; }
    public int ReceiverId { get; set; }

    // Navigation properties
    public virtual User? Sender { get; set; }
    public virtual User? Receiver { get; set; }
 
}
