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
    
    public partial class inventory
    {
        public int item_id { get; set; }
        public string item_name { get; set; }
        public int item_quantity { get; set; }
        public int category_id { get; set; }
        public decimal list_price { get; set; }
        public decimal item_cost { get; set; }
        public byte[] item_image { get; set; }
        public System.DateTime sale_start { get; set; }
        public System.DateTime sale_end { get; set; }
    
        public virtual product_category product_category { get; set; }
    }
}