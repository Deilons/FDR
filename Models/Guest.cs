using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.Models;

[Table("Guests")]
public class Guest
{    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(255, ErrorMessage = "Name cannot exceed 255 characters")]

    public string FirstName { get; set; }

    [Required]
    [MaxLength(255, ErrorMessage = "Last name cannot exceed 255 characters")]

    public string LastName { get; set; }

    [Required]
    [MaxLength(255, ErrorMessage = "Email cannot exceed 255 characters")]
    [EmailAddress (ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }

    [Required]
    [MaxLength(20, ErrorMessage = "Identification number cannot exceed 20 characters")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "Identification number must be numeric")]
    public string IdentificationNumber { get; set; }

    [Required]
    [MaxLength(20, ErrorMessage = "Phone number cannot exceed 20 characters")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "Phone number must be numeric")]
    public string PhoneNumber { get; set; }

    public DateOnly BirthDate { get; set; }

    //public ICollection<Booking> Bookings { get; set; }

}
