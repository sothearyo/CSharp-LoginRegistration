using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegist.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        
        [Required(ErrorMessage="Please enter your first name.")]
        [MinLength(2, ErrorMessage="First name must be at least 2 characters.")]
        [Display(Name="First Name:")]
        public string FirstName {get;set;}
        [Required(ErrorMessage="Please enter your last name.")]
        [MinLength(2, ErrorMessage="Last name must be at least 2 characters.")]
        [Display(Name="Last Name:")]
        public string LastName {get;set;}
        [Required(ErrorMessage="Please enter an email address.")]
        [EmailAddress(ErrorMessage="Please enter a valid email address.")]
        [Display(Name="Email:")]
        public string Email {get;set;}
        [Required(ErrorMessage="Please enter a password.")]
        [MinLength(8,ErrorMessage="Password must be 8 characters or longer.")]
        [DataType(DataType.Password)]
        [Display(Name="Password:")]
        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Required(ErrorMessage="Please confirm password.")]
        [Compare("Password", ErrorMessage="Passwords do not match.")]
        [Display(Name="Confirm PW:")]
        public string ConfirmPW {get;set;}
    }
}