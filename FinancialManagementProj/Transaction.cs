using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    class Transaction //Basically, the Logs
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public Transaction(int id, string description, decimal amount, DateTime date)
        {
            this.Id = id;
            this.Description = description;
            this.Amount = amount;
            this.Date = date;
        }
        public static List<Transaction> GetTransactionsByDateRange(List<Transaction> transactions, DateTime startDate, DateTime endDate)
        {
            return transactions.Where(t => t.Date >= startDate && t.Date <= endDate).ToList();
        }
        public static void AddTransaction(List<Transaction> transactions, string description, decimal amount, DateTime date)
        {
            int ff_Id = transactions.Count + 1;
            Transaction transaction = new Transaction(ff_Id, description, amount, date);
            transactions.Add(transaction);
        }
        public static decimal GetTotalAmount(List<Transaction> transactions)
        {
            decimal total = 0;
            foreach (Transaction transaction in transactions)
            {
                total += transaction.Amount;
            }
            return total;
        }
    }
}
