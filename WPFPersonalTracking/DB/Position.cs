using System;
using System.Collections.Generic;
using WPFPersonalTracking.DB;

#nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string PositionName { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
