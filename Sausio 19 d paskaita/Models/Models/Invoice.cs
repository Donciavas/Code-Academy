using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public struct Invoice
    {
        public string Sender { get; }
        private decimal Amount { get; }
        private string InvoiceNumber { get; }
        private static int InvoiceSeriesNumber { get; set; } = 0;

        public Invoice(string sender, decimal amount) : this()
        {
            Sender = sender;
            Amount = amount;
            InvoiceNumber = $"NR_{DateTime.Today.Year}_{DateTime.Today.Month}_{DateTime.Today.Day}_{InvoiceSeriesNumber++}";
        }
    }
}