using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BillingSystem.Models
{
    public class DocBillModel
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string Investigation { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Paid { get; set; }
        public Nullable<decimal> Due { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Expense { get; set; }
        public Nullable<decimal> ReferalAmount { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}