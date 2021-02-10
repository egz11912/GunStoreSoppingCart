using System;
namespace Gunstoreshoppingcart.Exceptions
{
    public class RoleTypeNotFound : Exception
    {
        public RoleTypeNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
