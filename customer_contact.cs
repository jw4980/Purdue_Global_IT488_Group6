//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eBIT_Application
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer_contact
    {
        public int contact_id { get; set; }
        public int customer_id { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
    
        public virtual customer customer { get; set; }
    }
}
