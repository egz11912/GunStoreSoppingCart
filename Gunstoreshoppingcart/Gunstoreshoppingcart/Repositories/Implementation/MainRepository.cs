using System;
using System.Collections.Generic;

namespace Gunstoreshoppingcart.Repositories.Implementation
{
    public class MainRepository<T> : IMainRepository<T>
    {
        public List<T> currentDatabase = new List<T>();

        public MainRepository() { }

        public void Delete(T Entity)
        {
            currentDatabase.Remove(Entity);
            Console.WriteLine("You deleted the Entity");
        }

        public void Save(T Entity)
        {
            currentDatabase.Add(Entity);
            Console.WriteLine("You saved the Entity");
        }

        public void Update(T Entity)
        {
            Console.WriteLine("You updated the Entity");
        }

         
    }
}
