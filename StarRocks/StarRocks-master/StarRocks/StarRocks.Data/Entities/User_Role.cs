﻿using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Entities
{
    public class User_Role : IUser_Role
    {
        public int RoleID { get; set; }
        public int AccountID { get; set; }
    }
}
