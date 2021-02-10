using System;
using Gunstoreshoppingcart.Models;

namespace Gunstoreshoppingcart.Repositories.Implementation
{
    public class CommentRepository : MainRepository<Comment>, IComments_Repository
    {
        public CommentRepository()
        {
        }

        public void GetAllComments()
        {
            Console.WriteLine("This is the comment: ");
        }
    }
}
