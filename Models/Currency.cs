//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelsLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Currency
    {
        public Currency()
        {
            this.ClaimFieldTemplates = new HashSet<ClaimFieldTemplate>();
        }
    
        public int CurrencyID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Sign { get; set; }
    
        public virtual ICollection<ClaimFieldTemplate> ClaimFieldTemplates { get; set; }
    }
}
