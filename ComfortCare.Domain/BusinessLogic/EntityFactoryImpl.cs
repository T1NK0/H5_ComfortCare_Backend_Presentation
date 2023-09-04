using ComfortCare.Domain.BusinessLogic.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComfortCare.Domain.BusinessLogic
{
    public class EntityFactoryImpl : IEntity
    {
        public T CreateEntity<T>() where T : new()
        {
            return new T();
        }

        public List<T> CreateEntityList<T>()
        {
            return new List<T>();
        }
    }
}
