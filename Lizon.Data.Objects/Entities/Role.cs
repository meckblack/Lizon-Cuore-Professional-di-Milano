using System.ComponentModel.DataAnnotations;

namespace Lizon.Data.Objects.Entities
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Role name field required")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
    }
}