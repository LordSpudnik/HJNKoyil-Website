using System;
using System.Collections.Generic;

namespace HJNKoyil.Models
{
    public partial class VwCommonMasterDtl
    {
        public int? CommonMasterId { get; set; }

        public string? CommonText { get; set; }

        public int Id { get; set; }

        public string? CommonItem { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }
    }
}