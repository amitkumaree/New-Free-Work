using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewFreeLanceComp.Models
{
    public sealed class JobBudget
    {
        /// <summary>
        /// <para>Fixed</para>
        /// <para>Hourly</para>
        /// </summary>
        public BudgetType BudgetType { get; set; }

        /// <summary>
        /// under 100
        /// 100 - 200
        /// 200 - 500
        /// 500 - 1000
        /// 1000 - 2500
        /// 2500 - 5000
        /// 5000 - 10000
        /// over 10000
        /// </summary>
        public string FixedBudgetOptions { get; set; }

        #region Hourly type properties
        /// <summary>
        /// duration of the job like
        /// 1 week, 1-3 week
        /// 1 month
        /// 3 monts 
        /// more than 3 months
        /// </summary>
        public string JobDuration { get; set; }
        public string HoursPerWeek { get; set; }
        public string MinimumRatePerHour { get; set; }
        public string MaximumRatePerHour { get; set; }
        #endregion
    }
}