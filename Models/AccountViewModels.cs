using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DrivingLicense.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

        public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "ელ.ფოსტის ველი აუცილებელია.")]
        [Display(Name = "ელ.ფოსტა")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name ="მომხმარებლის სახელი")]
        [Required]
        public string UserName { get; set; }

        [Required(ErrorMessage = "პაროლის ველი აუცილებელია.")]
        [DataType(DataType.Password)]
        [Display(Name = "პაროლი")]
        public string Password { get; set; }

        [Display(Name = "დამიმახსოვრე შესვლა ? ")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "ელ.ფოსტის ველი აუცილებელია.")]
        [EmailAddress]
        [Display(Name = "ელ.ფოსტა")]
        public string Email { get; set; }

        [Display(Name = "სახელი"), Required(ErrorMessage = "სახელის ველი აუცილებელია.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "პაროლის ველი აუცილებელია.")]
        [StringLength(100, ErrorMessage = "პაროლი უნდა იყოს მინიმუმ 6 სიმბოლო.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "პაროლი")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "გაიმეორეთ პაროლი")]
        [Compare("Password", ErrorMessage = "პაროლი და დადასტურება პაროლი არ ემთხვევა.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} უნდა იყოს არანაკლებ {2} სიმბოლო.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "პაროლი და დადასტურებული პაროლი არ ემთხვევა")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}