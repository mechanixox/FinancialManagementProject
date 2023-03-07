using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    class Budget 
    {
        public int Id { get; set; }
        public decimal totalIncome { get; set; }
        public decimal totalExpenses { get; set; }
        public DateTime Date { get; set; }
        public List<IncomeSource> incomes;
        public List<ExpenseSource> expenses;
        public int sourceId;
        public Budget(int id, DateTime date, Income income)
        {
            this.Id = id;
            this.Date = date;
            this.totalIncome = income.GetTotalIncome();
            incomes = new List<IncomeSource>();
            expenses = new List<ExpenseSource>();
        }

        public Budget(int id, DateTime date, Expense expense)
        {
            this.Id = id;
            this.Date = date;
            this.totalExpenses = expense.GetTotalExpenses();
            incomes = new List<IncomeSource>();
            expenses = new List<ExpenseSource>();
        }

        public void AddIncomeToBudget(string sourceName, decimal amount, DateTime date)
        {
            IncomeSource income = new IncomeSource(this.sourceId, sourceName, amount, date);
            incomes.Add(income);
            totalIncome += GetTotalIncome();
        }

        public void AddExpenseToBudget(string sourceName, decimal amount, DateTime date)
        {
            ExpenseSource expense = new ExpenseSource(this.sourceId, sourceName, amount, date);
            expenses.Add(expense);
            totalIncome -= GetTotalExpense();
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
