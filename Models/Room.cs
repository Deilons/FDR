using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.Models;

[Table("Rooms")]
public class Room
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(10, ErrorMessage = "Room number cannot be longer than 10 characters")]
    public string RoomNumber { get; set; }

    [ForeignKey("RoomType")]
    public int RoomTypeId { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public double PricePerNight { get; set; }

    [Required]
    public bool Available { get; set; }
    [Required]
    [Range(1, 20)] 
    public int MaxOccupancyPersons { get; set; }
}
