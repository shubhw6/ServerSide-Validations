using System.ComponentModel.DataAnnotations;

namespace ServerSide__Validations.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="User Name is required")]
        [StringLength(20,MinimumLength =3)]
        [Display(Name ="User Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "User Address is required")]
        [StringLength(200)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^([a-zA-Z0-9_.+-])+@(([a-zA-Z0-9-])+.)+([a-zA-Z0-9]{2,4})$", ErrorMessage ="Enter Valid Email Address")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression("^([+][9][1][1][0]){0,1}([6-9]{1})([0-9]{9})$",ErrorMessage ="Enter Valid Phone no.")]
        [Display(Name = "Phone Number")]


        public string MobileNumber { get; set; }
        [StringLength(20, MinimumLength = 6)]


        public string Password { get; set; }
        [Required(ErrorMessage = "Please Confirm your password")]
        [StringLength(20, MinimumLength = 6)]
        [Compare("Password",ErrorMessage ="Password not Matched")]

        public string ConfirmPassword { get; set; }


    }
}
