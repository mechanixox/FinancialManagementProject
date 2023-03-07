using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    class Income
    {
        public List<IncomeSource> job;
        public List<IncomeSource> incomes;
        private int sourceId;

        public Income()
        {
            this.incomes = new List<IncomeSource>();
            this.sourceId = 1; //keeps track of the unique income source ID
        }

        public void AddIncome(string sourceName, decimal amount, DateTime date)
        {
            IncomeSource income = new IncomeSource(this.sourceId, sourceName, amount, date, category);
            this.incomes.Add(income);
            this.sourceId++;
        }

        public decimal GetTotalIncome()
        {
            decimal totalIncome = 0;
            foreach (IncomeSource income in this.incomes)
            {
                totalIncome += income.Amount;
            }
            return totalIncome;
        }

        public decimal GetAverageIncome()
        {
            decimal totalIncome = this.GetTotalIncome();
            int numMonths = (DateTime.Today.Year - this.incomes[0].DateAdded.Year) * 12 + DateTime.Today.Month - this.incomes[0].DateAdded.Month + 1;
            decimal averageIncome = totalIncome / numMonths;
            return averageIncome;
        }

        public decimal GetIncomeByCategory(string category)
        {
            decimal totalIncome = 0;
            foreach (IncomeSource income in this.incomes)
            {
                if (income.Category == category)
                {
                    totalIncome += income.Amount;
                }
            }
            return totalIncome;
        }

        public decimal GetIncomeByMonth(int month, int year)
        {
            decimal totalIncome = 0;
            foreach (IncomeSource income in this.incomes)
            {
                if (income.DateAdded.Month == month && income.DateAdded.Year == year)
                {
                    totalIncome += income.Amount;
                }
            }
            return totalIncome;
        }
    }
}