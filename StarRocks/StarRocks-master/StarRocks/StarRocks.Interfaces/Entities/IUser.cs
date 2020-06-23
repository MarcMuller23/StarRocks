using System;
using System.Security.Principal;

namespace StarRocks.Interfaces.Entities
{
    public interface IUser
    {
        string Firstname { get; set; }
        string Preposition { get; set; }
        string Lastname { get; set; }
        string Street { get; set; }
        int Housenumber { get; set; }
        string Addition { get; set; }
        string Postcalcode { get; set; }
        string City { get; set; }
        DateTime Birthday { get; set; }
    }
}