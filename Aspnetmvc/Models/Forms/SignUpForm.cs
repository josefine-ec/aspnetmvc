using System.ComponentModel.DataAnnotations;

namespace Aspnetmvc.Models.Forms
{
    public class SignUpForm
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [StringLength(256, ErrorMessage = "Föramnet måste ha minst 2 bokstäver", MinimumLength = 2)]
        [RegularExpression(@"^([a-öA-Ö]+?)([-][a-öA-Ö]+)*?$", ErrorMessage = "Måste vara ett giltigt Förnamn")]
        public string FirstName { get; set; } = "";

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [StringLength(256, ErrorMessage = "Efternamnet måste ha minst 2 bokstäver", MinimumLength = 2)]
        [RegularExpression(@"^([a-öA-Ö]+?)([-\s][a-öA-Ö]+)*?$", ErrorMessage = "Måste vara ett giltigt Efternamn")]
        public string LastName { get; set; } = "";

        [Display(Name = "Street name")]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [StringLength(256, ErrorMessage = "Gatunamnet måste ha minst 2 bokstäver", MinimumLength = 2)]
        [RegularExpression(@"^([a-öA-Ö]+?)([\s][0-9]+)*?$", ErrorMessage = "Måste vara ett giltigt Gatunamn")]
        public string StreetName { get; set; } = "";

        [Display(Name = "Postal code")]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [StringLength(256, ErrorMessage = "Måste innehålla 5 siffror plus mellanslag", MinimumLength = 5)]
        [RegularExpression(@"^\d{3}(\s\d{2})?$", ErrorMessage = "Måste vara en giltig postkod (ex. 123 45)")]
        public string PostalCode { get; set; } = "";

        [Display(Name = "City")]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [StringLength(256, ErrorMessage = "Orten måste ha minst 2 bokstäver", MinimumLength = 2)]
        [RegularExpression(@"^([a-öA-Ö]+?)([\s][a-öA-Ö]+)*?$", ErrorMessage = "Måste vara en giltig Ort")]
        public string City { get; set; } = "";

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [StringLength(256, ErrorMessage = "Landet måste ha minst 2 bokstäver", MinimumLength = 2)]
        [RegularExpression(@"^([a-öA-Ö]+?)([\s][a-öA-Ö]+)*?$", ErrorMessage = "Måste vara ett giltigt Land")]
        public string Country { get; set; } = "Sverige";

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Måste vara en giltig E-mail")]
        public string Email { get; set; } = "";

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Lösenordet måste vara säkert")]
        public string Password { get; set; } = "";

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [Compare("Password", ErrorMessage = "Lösenorden matchar ej")]
        public string ConfirmPassword { get; set; } = "";

        public string ErrorMessage { get; set; } = "";
        public string ReturnUrl { get; set; } = "/";
        public string RoleName { get; set; } = "user";
    }
}
