using System;
namespace Gunstoreshoppingcart.Exceptions
{
    public class UserNameNotFound : Exception
    {
        public UserNameNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
