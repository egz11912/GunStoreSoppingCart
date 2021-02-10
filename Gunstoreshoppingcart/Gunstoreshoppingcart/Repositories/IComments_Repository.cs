using System;
using Gunstoreshoppingcart.Models;

namespace Gunstoreshoppingcart.Repositories
{
    public interface IComments_Repository : IMainRepository<Comment>
    {
        public void GetAllComments();
    }
}
