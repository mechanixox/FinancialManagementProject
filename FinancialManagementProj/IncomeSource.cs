using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementProj
{
    class IncomeSource
    {
        public int Id { get; set; } // identifies uniquely the income source
        public string SourceName { get; set; } //describes the income source
        public decimal Amount { get; set; } //amount of money received for the income source
        public DateTime DateAdded { get; set; } // date for which the income item was received
        public string? Category { get; set; } //where income item belongs

        public IncomeSource(int id, string sourceName, decimal amount, DateTime dateAdded, string category)
        {
            this.Id = id;
            this.SourceName = sourceName;
            this.Amount = amount;
            this.DateAdded = dateAdded;
            this.Category = category;
        }

       /* public int SourceId;
        public IncomeSource(int sourceId, string sourceName, decimal amount, DateTime dateAdded)
        {
            this.SourceId = sourceId;
            SourceName = sourceName;
            Amount = amount;
            DateAdded = dateAdded;
        }*/
    }
}

