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

namespace Azbil.Billing.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class VariableValue : IEntity
    {
        public int VariableValueId { get; set; }
        public int TariffRecordId { get; set; }
        public string Variable { get; set; }
        public Nullable<double> Value { get; set; }
        public string Status { get; set; }
    }
}
