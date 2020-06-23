using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;
using StarRocks.Interfaces.Entities;

namespace StarRocks.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        public string Firstname { get; set; }
        public string Preposition { get; set; }
        public string Lastname { get; set; }
        public string Street { get; set; }
        public int Housenumber { get; set; }
        public string Addition { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public DateTime Birthday { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }
}
