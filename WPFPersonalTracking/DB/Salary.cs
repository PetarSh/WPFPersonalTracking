using System;
using System.Collections.Generic;

#nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Salary
    {
        public int EmployeeId { get; set; }
        public int Amount { get; set; }
        public int Year { get; set; }
        public int MonthId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Month Month { get; set; }
    }
}
