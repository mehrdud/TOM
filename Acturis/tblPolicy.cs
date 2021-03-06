//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acturis
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPolicy
    {
        public int PolicyId { get; set; }
        public string PolicyReference { get; set; }
        public string ProgrammeReference { get; set; }
        public Nullable<int> ProductClassId { get; set; }
        public string ProductClass { get; set; }
        public string Product { get; set; }
        public Nullable<int> OwnershipTeamId { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public string BusinessType { get; set; }
        public string PolicyStatus { get; set; }
        public Nullable<int> PolicyStatusCode { get; set; }
        public Nullable<System.DateTime> AuthorizedDate { get; set; }
        public Nullable<System.DateTime> CancelledDate { get; set; }
        public Nullable<System.DateTime> InceptionDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string Backloaded { get; set; }
        public string BackloadDescription { get; set; }
        public Nullable<int> RenewedFromId { get; set; }
        public Nullable<int> RenewedToId { get; set; }
        public string PolicyExpired { get; set; }
        public string PolicyType { get; set; }
        public string MasterBinder { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<int> PrimaryHandlerId { get; set; }
        public string PrimaryHandlerName { get; set; }
        public Nullable<int> PrimaryHandlerTeamId { get; set; }
        public string PrimaryHandlerTeam { get; set; }
        public Nullable<int> PrimaryProducerId { get; set; }
        public string PrimaryProducerName { get; set; }
        public Nullable<int> PrimaryProducerTeamId { get; set; }
        public string PrimaryProducerTeam { get; set; }
        public Nullable<int> FirstClientId { get; set; }
        public string FirstClientName { get; set; }
        public string FirstClientCountry { get; set; }
        public Nullable<int> FirstInsuredId { get; set; }
        public string FirstInsuredName { get; set; }
        public string FirstInsuredCountry { get; set; }
        public Nullable<int> FirstReinsuredId { get; set; }
        public string FirstReinsuredName { get; set; }
        public string FirstReinsuredCountry { get; set; }
        public Nullable<int> FirstBusinessClassId { get; set; }
        public string FirstBusinessClass { get; set; }
        public string BusinessClassList { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
    }
}
