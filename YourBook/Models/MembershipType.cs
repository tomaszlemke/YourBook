using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YourBook.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurrationInMonths { get; set; }
        public byte DurrationOfLoan { get; set; }

    }
}