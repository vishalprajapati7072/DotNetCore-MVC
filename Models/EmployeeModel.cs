using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore_MVC.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [DisplayName("FirstName For Grid")]
        [StringLength(50, ErrorMessage = "Max length should not be more than 50")]
        public required string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [DisplayName("LastName")]
        [StringLength(25, ErrorMessage = "Max length should not be more than 50")]
        public required string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [DisplayName("Gender")]
        public int Gender { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime DOB { get; set; }
    }
}
