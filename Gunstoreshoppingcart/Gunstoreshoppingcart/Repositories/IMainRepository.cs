using System;
namespace Gunstoreshoppingcart.Repositories
{
    public interface IMainRepository<T>
    {
        public void Save(T Entity);
        
        public void Update(T Entity);

        public void Delete(T Entity);

    }
}
