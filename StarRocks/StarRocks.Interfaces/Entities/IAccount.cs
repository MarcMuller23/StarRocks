using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces
{
    public interface IAccount
    {
        string FirstName { get; set; }
        string Preposition { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string PhoneNumber { get; set; }
        string Street { get; set; }
        int HouseNumber { get; set; }
        string Addition { get; set; }
        string PostalCode { get; set; }
        string City { get; set; }
        DateTime Birthdate { get; set; }
    }
}
