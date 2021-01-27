using System;
namespace Gunstoreshoppingcart.Models
{
    public class Users
    {
        public Users()
        {
        }

        public string SuperUser { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public object ShowallComments { get; internal set; }

        internal void PrintMenu()
        {
            throw new NotImplementedException();
        }

        internal string CaptureResponse()
        {
            throw new NotImplementedException();
        }

        internal void CreateUser()
        {
            throw new NotImplementedException();
        }

        internal void CreateComment()
        {
            throw new NotImplementedException();
        }

        internal void ShowallUsers()
        {
            throw new NotImplementedException();
        }

        internal void ShowallComments()
        {
            throw new NotImplementedException();
        }
    }
}
