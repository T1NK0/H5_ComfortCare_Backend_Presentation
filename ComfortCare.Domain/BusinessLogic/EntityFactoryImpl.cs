using ComfortCare.Domain.BusinessLogic.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComfortCare.Domain.BusinessLogic
{
    public class EntityFactoryImpl : IEntityFactory
    {
        public T CreateNewEntity<T>() where T : new()
        {
            return new T();
        }

        public List<T> CreateNewEntityList<T>()
        {
            return new List<T>();
        }
    }
}
