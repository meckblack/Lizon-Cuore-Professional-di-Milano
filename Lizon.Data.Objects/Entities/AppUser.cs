using System.ComponentModel.DataAnnotations;

namespace Lizon.Data.Objects.Entities
{
    public class AppUser
    {
        [Key]
        public int AppUserId { get; set; }

        [Required(ErrorMessage = "First name field required")]
        [Display(Name = "First Name")]
        public string AppUserFirstName { get; set; }

        [Required(ErrorMessage = "Last name field required")]
        [Display(Name = "Last Name")]
        public string AppUserLastName { get; set; }

        [Display(Name = "Middle Name")]
        public string AppUserMiddleName { get; set; }

        [Required(ErrorMessage = "Username field required")]
        [Display(Name = "UserName")]
        public string AppUserName { get; set; }

        [Required(ErrorMessage = "Password field required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string AppUserPassword { get; set; }

        [Required(ErrorMessage = "Comfirm Password field required")]
        [Compare("AppUserPassword", ErrorMessage = "Passwords doesn't match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string AppUserConfirmPassword { get; set; }

        [Required(ErrorMessage = "Phone Number field required")]
        [Display(Name = "Phone Number")]
        public string AppUserPhoneNumber { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}