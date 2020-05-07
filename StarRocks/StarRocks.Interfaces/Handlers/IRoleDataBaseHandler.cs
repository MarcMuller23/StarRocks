using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Handlers
{
    public interface IRoleDataBaseHandler
    {
        List<IRole> GetAllRoles();

        void CreateRole(IRole R1);

        void UpdateRole(IRole R1);

        void DeleteRole(int ID);
    }
}

