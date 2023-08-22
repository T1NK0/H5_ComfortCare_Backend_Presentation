﻿using ComfortCare.Domain.BusinessLogic.interfaces;
using ComfortCare.Domain.Entities;

namespace ComfortCare.Domain.BusinessLogic
{
    /// <summary>
    /// This class is the manger for creating the statements plan for all the citizens, and schema's for all the employees
    /// uisng the ComfortCare Eco System
    /// </summary>
    public class PlanManager : IPlanManager
    {
        #region fields
        private readonly RouteGenerator _routeGen;
        #endregion

        #region Constructor
        public PlanManager(RouteGenerator routeGen)
        {
            _routeGen = routeGen;
        }
        #endregion

        #region Methods
        public List<RouteEntity> CalculateNewStatementPeriod(int numberOfDays, int numberOfAssignments)
        {
            var result = _routeGen.CalculateDaylyRoutes(numberOfDays, numberOfAssignments);
            return result;
        }       
        #endregion
    }
}
