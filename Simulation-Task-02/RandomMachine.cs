using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation_Task_02
{
    public enum DayType
    {
        Good,
        Fair,
        Poor
    }
    public class RandomMachine
    {
        private double[] P_Days;

        private DayType day_type;

        private int demand;

        public DayType Type
        {
            get{return day_type;}
        }

        public int Demand
        {
            get{return demand;}
        }

        private double[] P_Good, P_Fair, P_Poor;

        private Random rand;

        public RandomMachine(double[] P, double[] good, double[] fair, double[] poor)
        {
            this.P_Days = P;
            this.P_Good = good;
            this.P_Fair = fair;
            this.P_Poor = poor;
            rand = new Random(DateTime.Now.Millisecond);
        }

        public double GenerateDayType()
        {
            day_type = DayType.Poor;

            double N = rand.NextDouble();
            double cumulative = 0;
            cumulative += P_Days[0];
            if (N <= cumulative)
            {
                day_type = DayType.Good;
                return N;
            }

            cumulative += P_Days[1];
            if (N <= cumulative)
            {
                day_type = DayType.Fair;
                return N;
            }

            cumulative += P_Days[2];
            if (N <= cumulative)
            {
                day_type = DayType.Poor;
                return N;
            }
            
            return N;
        }

        public double GenerateDemandAmount()
        {
            demand = 40;
            double N = rand.NextDouble();
            double cumulative = 0;
            double[] arr;

            if (day_type == DayType.Poor)
                arr = P_Poor;
            else if (day_type == DayType.Fair)
                arr = P_Fair;
            else if (day_type == DayType.Good)
                arr = P_Good;
            else
                return demand;

            for (int i = 0; i < arr.Length; i++)
            {
                cumulative += arr[i];
                if(N <= cumulative)
                    return N;
                demand += 10;
            }

            return N;
        }
    }
}
