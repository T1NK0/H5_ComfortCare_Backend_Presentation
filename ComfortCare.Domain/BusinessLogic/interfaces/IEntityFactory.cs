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
        public AssignmentEntity CreateNewAssignmentEntity(); 
        public List<AssignmentEntity> CreateNewAssignmentsEntityList();

        public DistanceEntity CreateNewDistanceEntity();
        public List<DistanceEntity> CreateNewDistancesEntityList();

        public EmployeeEntity CreateNewEmployeeEntity();
        public List<EmployeeEntity> CreateNewEmployeeEntityList();

        public RouteEntity CreateNewRouteEntity();
        public List<RouteEntity> CreateNewRouteEntityList();

        public TimeSpanEntity CreateNewTimeSpanEntity();
        public List<TimeSpanEntity> CreateNewTimeSpanEntityList();
    }
}
