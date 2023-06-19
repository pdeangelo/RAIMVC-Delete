//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RAI_MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string WinUserID { get; set; }
        public int RoleID { get; set; }
        public int OfficeID { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public int Status { get; set; }
        public Nullable<int> FinanceGroup { get; set; }
        public Nullable<bool> AllSecurityAccess { get; set; }
        public Nullable<bool> AllPipelineAccess { get; set; }
        public Nullable<bool> IsAnalyst { get; set; }
        public Nullable<bool> IsFinance { get; set; }
        public Nullable<bool> IsManager { get; set; }
        public Nullable<bool> FundLevelAccess { get; set; }
        public Nullable<int> Client { get; set; }
        public string Password { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
