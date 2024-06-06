using System;
using System.Collections.Generic;

namespace HJNKoyil.Models
{

    public partial class CommonMasterDtl
    {
        public int Id { get; set; }

        public int? CommonMasterId { get; set; }

        public string? CommonItem { get; set; }

        public bool? IsActive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual ICollection<Donation> Donations { get; set; } = new List<Donation>();

        //public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}