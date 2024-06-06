using System;
using System.Collections.Generic;

namespace HJNKoyil.Models
{

    public partial class Individual
    {
        public int Id { get; set; }

        public string? FullName { get; set; }

        public string? MobileNumber { get; set; }

        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? Address3 { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? PinCode { get; set; }

        public int? IndividualRole { get; set; }

        public string? AspnetUserName { get; set; }
    }
}