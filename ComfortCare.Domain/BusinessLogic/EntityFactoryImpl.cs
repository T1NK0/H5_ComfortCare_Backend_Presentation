using ComfortCare.Domain.BusinessLogic.interfaces;
using ComfortCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComfortCare.Domain.BusinessLogic
{
    public class EntityFactoryImpl : IEntityFactory
    {
        public AssignmentEntity CreateNewAssignmentEntity()
        {
            return new AssignmentEntity();
        }
        public List<AssignmentEntity> CreateNewAssignmentListEntity() 
        {
            return new List<AssignmentEntity>();
        }

        public DistanceEntity CreateNewDistanceEntity() 
        { 
            return new DistanceEntity(); 
        }
        public List<DistanceEntity> CreateNewDistanceListEntity()
        {
            return new List<DistanceEntity>();
        }
        
        public EmployeeEntity  CreateNewEmployeeEntity()
        {
            return new EmployeeEntity();
        }
        public List<EmployeeEntity> CreateNewEmployeeListEntity()
        {
            return new List<EmployeeEntity>();
        }

        public RouteEntity CreateNewRouteEntity()
        {
            return new RouteEntity();
        }
        public List<RouteEntity> CreateNewRouteListEntity()
        {
            return new List<RouteEntity>();
        }

        public TimeSpanEntity CreateNewTimeSpanEntity() 
        { 
            return new TimeSpanEntity(); 
        }
        public List<TimeSpanEntity> CreateNewTimeSpanListEntity()
        {
            return new List<TimeSpanEntity>();
        }
    }
}
