using System;
using System.Collections.Generic;

namespace HJNKoyil.Models
{

    public partial class Donation
    {
        public int Id { get; set; }

        public int? DonatedBy { get; set; }

        public decimal? AmountDonated { get; set; }

        public int? DonationType { get; set; }

        public string? ReferenceInfo { get; set; }

        public DateTime? DonatedDate { get; set; }

        public string? Comments { get; set; }

        public bool? IsActive { get; set; }

        public int? CollectedBy { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        //public virtual CommonMasterDtl? DonationTypes { get; set; } = new CommonMasterDtl();
    }
}