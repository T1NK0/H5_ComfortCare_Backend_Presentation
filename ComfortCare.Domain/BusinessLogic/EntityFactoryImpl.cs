using ComfortCare.Domain.BusinessLogic.interfaces;
using ComfortCare.Domain.Entities;

namespace ComfortCare.Domain.BusinessLogic
{
    public class EntityFactoryImpl : IEntityFactory
    {
        public T CreateNewEntity<T>() where T: new()
        {
            return new T();
        }

        public List<T> CreateNewEntityList<T>()
        {
            return new List<T>();
        }
    }
}
