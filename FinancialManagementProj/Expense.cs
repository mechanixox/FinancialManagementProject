using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    class Expense
    {
        public int Id { get; set; }
        public string? SourceName { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public List<ExpenseSource> expenses;
        private int sourceId;

        //private decimal budget { get; set; }

        public Expense()
        {
            this.expenses = new List<ExpenseSource>();
            this.sourceId = 1;
        }

        public int GetNextExpenseId(Budget budget)
        {
            if (budget.expenses.Count == 0)
            {
                return 1;
            }

            int lastExpenseId = budget.expenses.Last().Id;
            return lastExpenseId + 1;
        }

        public void AddExpense(string sourceName, decimal amount, DateTime date)
        {
            ExpenseSource expense = new ExpenseSource(this.sourceId, sourceName, amount, date);
            this.expenses.Add(expense);
            this.sourceId++;
        }

        /* 
         public void RemoveExpense(int expenseId)
         {
             Expense expenseToRemove = Budget.expenses.FirstOrDefault(e => e.Id == expenseId);

             if (expenseToRemove != null)
             {
                 Budget.expenses.Remove(expenseToRemove);
             }
         }
        */
        public decimal GetTotalExpenses()
        {
            decimal totalExpenses = 0;

            foreach (Expense expense in budget.expenses)
            {
                totalExpenses += expense.Amount;
            }

            return totalExpenses;
        }

        public Expense GetExpenseById(int expenseId)
        {
            Expense expense = budget.expenses.FirstOrDefault(e => e.Id == expenseId);

            return expense;
        }
    }

}
