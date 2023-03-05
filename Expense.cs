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
        public string? Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }


        public int GetNextExpenseId()
        {
            if (Budget.expenses.Count == 0)
            {
                return 1;
            }

            int lastExpenseId = Budget.expenses.Last().Id;
            return lastExpenseId + 1;
        }

        public void AddExpense(string description, double amount, DateTime date)
        {
            Expense expense = new Expense
            {
                Id = GetNextExpenseId(),
                Description = description,
                Amount = amount,
                Date = date,
            };

            Budget.expenses.Add(expense);
        }

        public void RemoveExpense(int expenseId)
        {
            Expense expenseToRemove = Budget.expenses.FirstOrDefault(e => e.Id == expenseId);

            if (expenseToRemove != null)
            {
                Budget.expenses.Remove(expenseToRemove);
            }
        }


    }

}
