//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// imports IEntity interface 
using Azbil.Billing.Entities.Interfaces;

namespace Azbil.Billing.Entities.Billing
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChangeLog : IEntity
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string PropertyName { get; set; }
        public string PrimaryKey { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public Nullable<System.DateTime> DateChanged { get; set; }
        public Nullable<int> ChangedBy { get; set; }
    }
}
