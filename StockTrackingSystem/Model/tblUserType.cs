//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTrackingSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUserType
    {
        public int userTypeID { get; set; }
        public int userID { get; set; }
        public int typeID { get; set; }
    
        public virtual tblTypes tblTypes { get; set; }
        public virtual tblUsers tblUsers { get; set; }
    }
}
