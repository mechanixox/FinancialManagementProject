using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    class Budget
    {
        private decimal totalIncome;
        private decimal totalExpense;
        private List<IncomeSource> incomes;
        private List<ExpenseSource> expenses;

        public Budget()
        {
            totalIncome = 0;
            totalExpense = 0;
            incomes = new List<IncomeSource>();
            expenses = new List<ExpenseSource>();
        }

        public void AddIncome(string sourceName, decimal amount, DateTime date)
        {
            IncomeSource income = new IncomeSource(this.sourceId, sourceName, amount, date);
            incomes.Add(income);
            totalIncome += amount;
        }

        public void AddExpense(string sourceName, decimal amount, DateTime date)
        {
            ExpenseSource expense = new ExpenseSource(this.sourceId, sourceName, amount, date);
            expenses.Add(expense);
            totalExpense = totalExpense + amount;
        }

        public decimal GetTotalIncome()
        {
            return totalIncome;
        }

        public decimal GetTotalExpense()
        {
            return totalExpense;
        }

        public decimal GetBalance()
        {
            return totalIncome - totalExpense;
        }

        public List<IncomeSource> GetIncomes()
        {
            return incomes;
        }

        public List<ExpenseSource> GetExpenses()
        {
            return expenses;
        }
    }

}
