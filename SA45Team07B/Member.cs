//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA45Team07B
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public Member()
        {
            this.IssueTrans = new HashSet<IssueTran>();
        }
    
        public long MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberType { get; set; }
        public string FacultyCode { get; set; }
        public string SchoolID { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Discontinued { get; set; }
        public short LoanedQty { get; set; }
    
        public virtual Faculty Faculties { get; set; }
        public virtual ICollection<IssueTran> IssueTrans { get; set; }
        public virtual MemberCategories MemberCategories { get; set; }
    }
}