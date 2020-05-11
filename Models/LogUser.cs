using System.ComponentModel.DataAnnotations;

namespace LoginRegist.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage="Please enter an email address.")]
        [EmailAddress(ErrorMessage="Please enter a valid email address.")]
        [Display(Name="Email:")]
        public string UserEmail {get;set;}

        [Required(ErrorMessage="Please enter a password.")]
        [DataType(DataType.Password)]
        [Display(Name="Password:")]
        public string UserPassword {get;set;}

        // public LogUser()
        // {
        //     UserEmail=null;
        //     UserPassword=null;
        // }

        // public LogUser(string email, string password)
        // {
        //     UserEmail = email;
        //     UserPassword = password;
        // }


    }

}
