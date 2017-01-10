using System.ComponentModel.DataAnnotations;

namespace MSBuildLogsExtended.AspNetMvc50AngularSPA.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Common_EmailLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string Action { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Common_CurrentPasswordLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Common_PasswordErrorMessage", MinimumLength = 6, ErrorMessageResourceType = typeof(Framework.Resources.UIStringResource))]
        [DataType(DataType.Password)]
        [Display(Name = "Common_NewPasswordLabelText")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Common_ConfirmPasswordLabelText")]
        [Compare("NewPassword", ErrorMessage = "Common_ConfirmPasswordNotMatchErrorMessage", ErrorMessageResourceType = typeof(Framework.Resources.UIStringResource))]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Common_EmailLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Common_PasswordLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public string Password { get; set; }

        [Display(Name = "Account_LogIn_RememberMeText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Common_EmailLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Common_PasswordErrorMessage", MinimumLength = 6, ErrorMessageResourceType = typeof(Framework.Resources.UIStringResource))]
        [DataType(DataType.Password)]
        [Display(Name = "Common_PasswordLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Common_ConfirmPasswordLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        [Compare("Password", ErrorMessage = "Common_ConfirmPasswordNotMatchErrorMessage", ErrorMessageResourceType = typeof(Framework.Resources.UIStringResource))]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Common_EmailLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Common_PasswordErrorMessage", MinimumLength = 6, ErrorMessageResourceType = typeof(Framework.Resources.UIStringResource))]
        [DataType(DataType.Password)]
        [Display(Name = "Common_PasswordLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Common_ConfirmPasswordLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        [Compare("Password", ErrorMessage = "Common_ConfirmPasswordNotMatchErrorMessage", ErrorMessageResourceType = typeof(Framework.Resources.UIStringResource))]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Common_EmailLabelText", ResourceType = typeof(Framework.Resources.UIStringResource))]
        public string Email { get; set; }
    }
}


