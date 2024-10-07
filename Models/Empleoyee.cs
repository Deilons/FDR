using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FDR.Models;

[Table("Employees")]
public class Empleoyee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]

    public string FirstName { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]

    public string LastName { get; set; }

    [Required]
    [MaxLength(255, ErrorMessage = "Email cannot exceed 255 characters")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }

    [Required]
    [MaxLength(20, ErrorMessage = "Identification number cannot exceed 20 characters")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "Identification number must be numeric")]
    public string IdentificationNumber { get; set; }

    [Required]
    [MaxLength(255, ErrorMessage = "Password cannot exceed 255 characters")]
    public string Password { get; set; }

    //public ICollection<Booking> Bookings { get; set; }

}
