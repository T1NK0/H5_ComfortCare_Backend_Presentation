﻿namespace ComfortCare.Domain.Entities
{
    /// <summary>
    /// This class is the _entity of a single route that contains a list of assignment for a single day
    /// </summary>
    public class RouteEntity
    {
        #region Shorthand properties
        public Guid RouteGuid { get; set; }
        public List<AssignmentEntity> Assignments { get; set; }
        public DateTime RouteDate { get; set; }
        #endregion

        #region Properties
        public double TotalRouteTimeInHours
        {
            get { return ((Assignments.Last().ArrivalTime.AddSeconds(Assignments.Last().Duration) - Assignments.First().ArrivalTime).TotalHours); }
        }

        public int NumberOfAssignment
        {
            get { return Assignments.Count; }
        }
        #endregion
    }
}
