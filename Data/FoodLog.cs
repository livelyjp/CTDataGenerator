//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTDataGenerator.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoodLog
    {
        public string FoodLogID { get; set; }
        public string MealID { get; set; }
        public int UserID { get; set; }
        public decimal Quantity { get; set; }
        public string CreationTimestamp { get; set; }
    
        public virtual Food FoodLogFood { get; set; }
        public virtual User FoodLogUser { get; set; }
    }
}