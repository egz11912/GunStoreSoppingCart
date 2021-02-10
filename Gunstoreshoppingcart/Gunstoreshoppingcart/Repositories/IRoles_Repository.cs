using System;
using Gunstoreshoppingcart.Models;

namespace Gunstoreshoppingcart.Repositories
{
    public interface IRoles_Repository : IMainRepository<Roles>
    {
        public void GetAllRoles();
    }
}
