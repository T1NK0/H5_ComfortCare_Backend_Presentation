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
        public List<AssignmentEntity> CreateNewAssignmentListEntity();
        public DistanceEntity CreateNewDistanceEntity();
        public List<DistanceEntity> CreateNewDistanceListEntity();
        public EmployeeEntity CreateNewEmployeeEntity();
        public List<EmployeeEntity> CreateNewEmployeeListEntity();
        public RouteEntity CreateNewRouteEntity();
        public List<RouteEntity> CreateNewRouteListEntity();
        public TimeSpanEntity CreateNewTimeSpanEntity();
        public List<TimeSpanEntity> CreateNewTimeSpanListEntity();
    }
}
