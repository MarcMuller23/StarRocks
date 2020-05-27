﻿using StarRocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Entities
{
    public class Account : IAccount
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Preposition { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Addition { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public DateTime Birthdate { get; set; }
    }
}