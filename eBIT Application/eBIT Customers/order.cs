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
    
    public partial class order
    {
        public int order_id { get; set; }
        public int customer_id { get; set; }
        public decimal sale_price { get; set; }
        public int order_quantity { get; set; }
        public decimal tax { get; set; }
        public decimal ship_cost { get; set; }
        public decimal order_total { get; set; }
        public string tracking { get; set; }
    
        public virtual customer customer { get; set; }
    }
}
