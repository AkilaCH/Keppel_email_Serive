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
    
    public partial class PQ : IEntity
    {
        public int PQId { get; set; }
        public int PlantId { get; set; }
        public string Variable { get; set; }
        public double Value { get; set; }
        public System.DateTime EffectiveFrom { get; set; }
        public System.DateTime EffectiveTo { get; set; }
        public string Status { get; set; }
        public int InsertUserId { get; set; }
        public Nullable<int> UpdatedUserId { get; set; }
        public System.DateTime InsertedTime { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
    }
}
