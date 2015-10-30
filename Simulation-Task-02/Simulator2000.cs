using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Task_02
{
    public class Simulator2000
    {
        private RandomMachine randomMachine;

        private double totalSaleRev, totalLostProfit, totalScrapRev;
        private int totalDaysExcess, totalDaysUnsold;
        private double totalNewsCost, totalNetProfit;
        public double MinimumProfit { get; private set; }
        public double MaximumProfit { get; private set; }

        public double TotalSaleRevenue
        {
            get{return totalSaleRev;}
        }

        public double TotalLostProfit
        {
            get { return totalLostProfit; }
        }

        public double TotalScrapRevenue
        {
            get{return totalScrapRev;}
        }

        public int TotalDaysExcess
        {
            get{return totalDaysExcess;}
        }

        public int TotalDaysUnsold
        {
            get { return totalDaysUnsold; }
        }

        public double TotalNewsCost
        {
            get{return totalNewsCost;}
        }

        public double TotalNetProfit
        {
            get { return totalNetProfit; }
        }

        public Simulator2000(RandomMachine _randomMachine)
        {
            randomMachine = _randomMachine;
        }


        public SimulationInfo[] Simulate(int days, double buyPrice, double salePrice, double scrapPrice, int Amount)
        {
            totalSaleRev = 0;
            totalLostProfit = 0;
            totalScrapRev = 0;
            totalDaysUnsold = 0;
            totalDaysExcess = 0;
            MinimumProfit = Double.MaxValue;
            MaximumProfit = Double.MinValue;

            if (randomMachine == null)
                return null;

            SimulationInfo[] data = new SimulationInfo[days];
            for (int i = 0; i < days; i++)
            {
                SimulationInfo instance = new SimulationInfo();
                instance.Day = i + 1;
                instance.type_rand = (int)(randomMachine.GenerateDayType()*100);
                instance.day_type = randomMachine.Type;
                instance.demand_random = (int)(randomMachine.GenerateDemandAmount()*100);
                instance.demand = randomMachine.Demand;
                instance.sales_revenue = Amount > randomMachine.Demand
                    ? randomMachine.Demand*salePrice
                    : Amount*salePrice;
                instance.lost_profit = Amount < randomMachine.Demand
                    ? (randomMachine.Demand - Amount)*(salePrice - buyPrice)
                    : 0;
                instance.scrap_sales = Amount > randomMachine.Demand ? (Amount - randomMachine.Demand) * scrapPrice : 0;
                instance.daily_profit = instance.sales_revenue - (Amount*buyPrice) - instance.lost_profit +
                                        instance.scrap_sales;

                instance.sales_revenue = Math.Truncate(instance.sales_revenue * 100) / 100;
                instance.lost_profit = Math.Truncate(instance.lost_profit * 100) / 100;
                instance.scrap_sales = Math.Truncate(instance.scrap_sales * 100) / 100;
                instance.daily_profit = Math.Truncate(instance.daily_profit * 100) / 100;

                MinimumProfit = Math.Min(MinimumProfit, instance.daily_profit);
                MaximumProfit = Math.Max(MaximumProfit, instance.daily_profit);
                totalSaleRev += instance.sales_revenue;
                totalLostProfit += instance.lost_profit;
                totalScrapRev += instance.scrap_sales;

                if (instance.demand > Amount)
                    totalDaysExcess++;
                if (Amount > instance.demand)
                    totalDaysUnsold++;

                data[i] = instance;
            }

            totalNewsCost = (double)Amount * buyPrice;
            totalNetProfit = totalSaleRev - TotalNewsCost - totalLostProfit + totalScrapRev;

            return data;
        }
    }
}
