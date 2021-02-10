using System;
using System.Collections.Generic;
using System.Linq;
using Gunstoreshoppingcart.Exceptions;
using Gunstoreshoppingcart.Models;

namespace Gunstoreshoppingcart.Repositories.Implementation
{
    public class RolesRepository : MainRepository<Roles>, IRoles_Repository
    {
        public RolesRepository()
        {

        }

        public void GetAllRoles()
        {
            List<Roles> resultList =
               currentDatabase.Where(Roles => Roles.RoleType == "Supervisor").ToList();

            if (resultList.Count > 0)
            {
                foreach (var role in resultList)
                {
                    Console.WriteLine(role.RoleName);
                    Console.WriteLine(role.RoleType);
                }
                
                    
                
            }
            else
            {
                throw new RoleTypeNotFound("No role of that type found");
            }
        }
    }
}
