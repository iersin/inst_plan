using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentPlan
{
    public class CollectionPlanInstalment
    {

        public DateTime InstalmentDate;
        public DateTime ValueDate;
        public int DayCount;
        public int DayDiff;
        public int MonthCount;
        public int MonthDiff;
        public decimal Cost;
        public decimal IRD;
        public decimal Amount;
        public decimal Profit;
        public decimal PeriodicProfit;
        public decimal GrossCumulativeProfit;
        public decimal Kkdf;
        public decimal Bsmv;
        public bool IsGrossCalculation;
        public decimal RemainderProfit;
        public decimal RemainderCost;
        public decimal CumulativeProfit;

    }
}
