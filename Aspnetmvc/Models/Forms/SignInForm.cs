using System.ComponentModel.DataAnnotations;

namespace Aspnetmvc.Models.Forms
{
    public class SignInForm
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Måste vara en giltig E-mail")]
        public string Email { get; set; } = "";

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Fältet får inte vara tomt")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Lösenordet måste vara säkert")]
        public string Password { get; set; } = "";


        public string ErrorMessage { get; set; } = "";
        public string ReturnUrl { get; set; } = "/";
    }
}
