//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eBIT_Customers
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer_address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer_address()
        {
            this.customers = new ObservableListSource<customer>();
        }
    
        public int address_id { get; set; }
        public int customer_id { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public short zip { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customer> customers { get; set; }
    }
}
