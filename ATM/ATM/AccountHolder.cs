//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATM
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountHolder
    {
        public int id { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public Nullable<int> AccountLink { get; set; }
    
        public virtual atrmlogin atrmlogin { get; set; }
    }
}
