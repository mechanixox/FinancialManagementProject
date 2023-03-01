using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    public class Income
    {
        public string? IncomeSource { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        private double currentIncome { get; set; }

        public Income(string incomeSource, int amount, DateTime date) 
        {
            this.IncomeSource = incomeSource;
            this.Amount = 0;
            this.Date = date;
            this.currentIncome = 0;
        }

        public void AddIncome(string incomeSource, int amount, DateTime date)
        {
            this.currentIncome += amount;
        }

        public double GetTotalIncome()
        {
            double totalIncome = 0;
            if(currentIncome > 0)
                totalIncome += currentIncome;
            return totalIncome;
        }

    }


}