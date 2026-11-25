using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstructorSystem.Models;

public class Instructor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Required(ErrorMessage = "Instructor ID is required.")]
    [StringLength(50, ErrorMessage = "Instructor ID cannot exceed 50 characters.")]
    [Display(Name = "Instructor ID")]
    public string InstructorId { get; set; } = string.Empty;

    [Required(ErrorMessage = "Full name is required.")]
    [StringLength(150)]
    [Display(Name = "Full Name")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Department selection is required.")]
    [StringLength(100)]
    [Display(Name = "Department")]
    public string Department { get; set; } = string.Empty;

    [Required(ErrorMessage = "Age is required.")]
    [StringLength(20)]
    [Display(Name = "Age")]
    public string Age { get; set; } = "N/A";

    [Required(ErrorMessage = "Bachelor's degree is required.")]
    [StringLength(150)]
    [Display(Name = "Bachelor's Degree")]
    public string BachelorDegree { get; set; } = "N/A";

    [Required(ErrorMessage = "Majorship is required.")]
    [StringLength(100)]
    [Display(Name = "Majorship")]
    public string Majorship { get; set; } = "N/A";

    [Required(ErrorMessage = "Address is required.")]
    [StringLength(250)]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Gender is required.")]
    [StringLength(30)]
    public string Gender { get; set; } = string.Empty;

    [Required(ErrorMessage = "E-mail address is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid e-mail address.")]
    [StringLength(254)]
    [Display(Name = "E-mail Address")]
    public string EmailAddress { get; set; } = string.Empty;
}
