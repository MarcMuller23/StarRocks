using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Entities
{
    public interface IUser_Role
    {
         int RoleID { get; set; }
         int AccountID { get; set; }
    }
}
