using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.Models;

    public class RoomType
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [MaxLength(255, ErrorMessage = "Description cannot be longer than 255 characters.")]
        public string Description { get; set; }
        
        public ICollection<Room> Rooms { get; set; }
    }
