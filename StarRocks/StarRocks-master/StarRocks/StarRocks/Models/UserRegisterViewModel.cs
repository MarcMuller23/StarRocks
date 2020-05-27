using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using StarRocks.Data.Entities;

namespace StarRocks.Models
{
    public class UserRegisterViewModel : User
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is niet ingevuld")]
        public override string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public override string PasswordHash { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("PasswordHash")]
        public string ConfirmPassword { get; set; }

        public string Role { get; set; }

        public IEnumerable<SelectListItem> RoleList { get; set; }
    }
}