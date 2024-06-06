using System;
using System.Collections.Generic;

namespace HJNKoyil.Models
{

    public partial class CommonMaster
    {
        public int Id { get; set; }

        public string? CommonText { get; set; }

        public bool? IsActive { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}