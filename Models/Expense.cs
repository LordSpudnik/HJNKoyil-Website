using System;
using System.Collections.Generic;

namespace HJNKoyil.Models
{
    public partial class Expense
    {
        public int Id { get; set; }

        public int? ServiceProviderId { get; set; }

        public decimal? Amount { get; set; }

        public string? Comments { get; set; }

        public int? ExpenseType { get; set; }

        public bool? IsActive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? PaidBy { get; set; }

        public DateTime? ExpenseDate { get; set; }

        //public virtual CommonMasterDtl? ExpenseTypeNavigation { get; set; }
    }
}
