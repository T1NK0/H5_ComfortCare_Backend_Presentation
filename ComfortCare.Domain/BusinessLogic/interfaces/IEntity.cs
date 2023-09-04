using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComfortCare.Domain.BusinessLogic.interfaces
{
    public interface IEntity
    {
        public T CreateEntity<T>() where T: new();
        public List<T> CreateEntityList<T>();
    }
}
