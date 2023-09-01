using ComfortCare.Domain.BusinessLogic.interfaces;
using ComfortCare.Domain.Entities;

namespace ComfortCare.Domain.BusinessLogic
{
    public class EntityFactoryImpl : IEntityFactory
    {
        public AssignmentEntity CreateNewAssignmentEntity()
        {
            return new AssignmentEntity();
        }
        public List<AssignmentEntity> CreateNewAssignmentsEntityList()
        {
            return new List<AssignmentEntity>();
        }

        public DistanceEntity CreateNewDistanceEntity()
        {
            return new DistanceEntity();
        }
        public List<DistanceEntity> CreateNewDistancesEntityList() 
        { 
            return new List<DistanceEntity>(); 
        }

        public EmployeeEntity CreateNewEmployeeEntity()
        {
            return new EmployeeEntity();
        }
        public List<EmployeeEntity> CreateNewEmployeeEntityList()
        {
            return new List<EmployeeEntity>();
        }

        public RouteEntity CreateNewRouteEntity()
        {
            return new RouteEntity();
        }
        public List<RouteEntity> CreateNewRouteEntityList()
        {
            return new List<RouteEntity>();
        }

        public TimeSpanEntity CreateNewTimeSpanEntity()
        {
            return new TimeSpanEntity();
        }
        public List<TimeSpanEntity> CreateNewTimeSpanEntityList()
        {
            return new List<TimeSpanEntity>();
        }
    }
}
