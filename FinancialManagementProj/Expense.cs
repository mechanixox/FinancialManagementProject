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

        public Expense()
        {
            this.expenses = new List<ExpenseSource>();
            this.sourceId = 1;
        }

        public int GetNextExpenseId()
        {
            if (Budget.expenses.Count == 0)
            {
                return 1;
            }

            int lastExpenseId = Budget.expenses.Last().Id;
            return lastExpenseId + 1;
        }

        public void AddExpense(string sourceName, decimal amount, DateTime date)
        {
            ExpenseSource expense = new ExpenseSource(this.sourceId, sourceName, amount, date);

            Budget.expenses.Add(expense);
            //this.expenses.Add(expense);
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


    }

}
