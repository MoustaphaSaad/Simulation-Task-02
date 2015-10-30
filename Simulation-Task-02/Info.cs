using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Task_02
{
    public class DemandInfo
    {
        public double Good { get; set; }
        public double Fair { get; set; }
        public double Poor { get; set; }
    }

    public class DayInfo
    {
        public double DayProbability { get; set; }
    }

    public class SimulationInfo
    {
        [DisplayName("Day")]
        public int Day { get; set; }

        [DisplayName("Day Type Random")]
        public double type_rand { get; set; }

        [DisplayName("Day Type")]
        public DayType day_type { get; set; }

        [DisplayName("Demand Random")]
        public double demand_random { get; set; }

        [DisplayName("Demand")]
        public int demand { get; set; }

        [DisplayName("Sales Revenue")]
        public double sales_revenue { get; set; }

        [DisplayName("Lost Profit")]
        public double lost_profit { get; set; }

        [DisplayName("Scrap Sales")]
        public double scrap_sales { get; set; }

        [DisplayName("Daily Profit")]
        public double daily_profit { get; set; }
    }

    public class ReportInfo
    {
        public double TotalSalRevenue { get; set; }
        public double TotalNewsCost { get; set; }
        public double TotalLostProfit { get; set; }
        public double TotalScrapRevenue { get; set; }
        public double TotalNetProfit { get; set; }
        public int TotalDaysExcess { get; set; }
        public int TotalDaysUnsold { get; set; }
    }
}
