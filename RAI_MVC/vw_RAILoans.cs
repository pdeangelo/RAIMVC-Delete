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
    
    public partial class vw_RAILoans
    {
        public int LoanID { get; set; }
        public Nullable<int> LoanClientID { get; set; }
        public Nullable<int> LoanEntityID { get; set; }
        public Nullable<int> LoanInvestorID { get; set; }
        public Nullable<int> LoanStatusID { get; set; }
        public string LoanNumber { get; set; }
        public Nullable<System.DateTime> LoanFundingDate { get; set; }
        public string LoanMortgagee { get; set; }
        public string LoanPropertyAddress { get; set; }
        public Nullable<double> LoanInterestRate { get; set; }
        public Nullable<double> LoanMortgageAmount { get; set; }
        public Nullable<double> LoanAdvanceRate { get; set; }
        public Nullable<int> LoanTypeID { get; set; }
        public Nullable<System.DateTime> LoanEnteredDate { get; set; }
        public Nullable<System.DateTime> LoanUpdateDate { get; set; }
        public Nullable<int> LoanUpdateUserID { get; set; }
        public string LoanMortgageeBusiness { get; set; }
        public Nullable<int> LoanDwellingType { get; set; }
        public Nullable<int> StateID { get; set; }
        public string ClientName { get; set; }
        public string InvestorName { get; set; }
        public string CustodianName { get; set; }
        public string EntityName { get; set; }
        public string LoanStatus { get; set; }
        public string LoanDwellingTypeName { get; set; }
        public string State { get; set; }
        public Nullable<double> LoanAdvanceAmount { get; set; }
        public Nullable<double> LoanReserveAmount { get; set; }
        public Nullable<double> InterestIncome { get; set; }
        public Nullable<double> OriginationFee { get; set; }
        public Nullable<double> UnderwritingFee { get; set; }
        public Nullable<System.DateTime> DateDepositedInEscrow { get; set; }
        public Nullable<System.DateTime> InvestorProceedsDate { get; set; }
        public string LoanTypeName { get; set; }
        public Nullable<double> LoanMinimumInterest { get; set; }
    }
}
