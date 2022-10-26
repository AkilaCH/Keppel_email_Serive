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
    
    public partial class TariffRecord : IEntity
    {
        public int TariffRecordId { get; set; }
        public int BillingUnitId { get; set; }
        public double DDL { get; set; }
        public Nullable<System.DateTime> DCEffectiveFrom { get; set; }
        public Nullable<System.DateTime> ECEffectiveFrom { get; set; }
        public Nullable<System.DateTime> DCEffectiveTo { get; set; }
        public Nullable<System.DateTime> ECEffectiveTo { get; set; }
        public Nullable<double> DCAnnumRate { get; set; }
        public Nullable<double> DCMonthlyRate { get; set; }
        public Nullable<double> ECRate { get; set; }
        public int Year { get; set; }
        public int QuaterNo { get; set; }
        public string Status { get; set; }
        public int InsertUserId { get; set; }
        public System.DateTime InsertDateTime { get; set; }
    }
}
