using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using StarRocks.Data.Entities;

namespace StarRocks.Models
{
    public class UserLoginViewModel : User
    {
        [Required(ErrorMessage = "Email moet ingevuld worden!")]
        [DataType(DataType.EmailAddress)]
        public override string Email { get; set; }

        [Required(ErrorMessage = "Wachtwoord moet ingevuld worden!")]
        [DataType(DataType.Password)]
        public override string PasswordHash { get; set; }
    }
}