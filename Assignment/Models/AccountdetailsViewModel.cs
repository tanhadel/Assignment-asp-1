using System.ComponentModel.DataAnnotations;

namespace Assignment.Models;

public class AccountdetailsViewModel
{

    [Display(Name = "First name", Prompt = "John")]
    [Required(ErrorMessage = "A valid first name is required")]
    [MinLength(2, ErrorMessage = "A valid first name is required")]
    [DataType(DataType.Text)]
    public string FirstName { get; set; } = null!;



    [Display(Name = "Last name", Prompt = "Doe")]
    [Required(ErrorMessage = "A valid last name is required")]
    [MinLength(2, ErrorMessage = "A valid last name is required")]
    [DataType(DataType.Text)]
    public string LastName { get; set; } = null!;


    [Display(Name = "Email address", Prompt = "john.doe@domain.com")]
    [Required(ErrorMessage = "A valid email address is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone", Prompt = "Enter your phone")]
    [Required(ErrorMessage = "A valid phone number is required")]
    [MinLength(10, ErrorMessage = "A valid password is required")]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; } = null!;

    [Display(Name = "Bio", Prompt = "Add a short bio...")]
    [Required(ErrorMessage = "A valid password is required")]
    [MinLength(200, ErrorMessage = "A valid password is required")]
    [DataType(DataType.Text)]
    public string Bio { get; set; } = null!;
}
