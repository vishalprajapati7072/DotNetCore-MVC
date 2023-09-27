using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore_MVC.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [DisplayName("UserName")]
        [StringLength(50, ErrorMessage = "Max length should not be more than 50")]
        public required string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [DisplayName("Password")]
        [StringLength(25, ErrorMessage = "Max length should not be more than 50")]
        public required string Password { get; set; }
    }
}
