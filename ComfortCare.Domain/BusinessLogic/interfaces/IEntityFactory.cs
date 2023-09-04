using ComfortCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComfortCare.Domain.BusinessLogic.interfaces
{
    public interface IEntityFactory
    {
        public T CreateNewEntity<T>() where T : new();
        public List<T> CreateNewEntityList<T>();
    }
}
