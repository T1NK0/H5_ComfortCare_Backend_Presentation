﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ComfortCare.Data.Models
{
    public partial class EmployeeRoute
    {
        public EmployeeRoute()
        {
            EmployeeEmployeeRoute = new HashSet<EmployeeEmployeeRoute>();
        }

        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public DateTime ArrivalTime { get; set; }

        public virtual Assignment Assignment { get; set; }
        public virtual ICollection<EmployeeEmployeeRoute> EmployeeEmployeeRoute { get; set; }
    }
}