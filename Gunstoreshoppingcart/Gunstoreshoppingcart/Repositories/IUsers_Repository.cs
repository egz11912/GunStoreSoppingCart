using System;
using Gunstoreshoppingcart.Models;

namespace Gunstoreshoppingcart.Repositories
{
    public interface IUsers_Repository : IMainRepository<Users>
    {
        public void GetAllUsersByName(string name);
    }
}
