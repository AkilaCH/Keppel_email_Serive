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
    
    public partial class ADLRecord : IEntity
    {
        public int ADLRecordId { get; set; }
        public int MonthlyBillSummaryId { get; set; }
        public System.DateTime Date { get; set; }
        public double StartValue { get; set; }
        public double EndValue { get; set; }
        public System.DateTime ADLStart1 { get; set; }
        public System.DateTime ADLEnd1 { get; set; }
        public double ADLDuration1 { get; set; }
        public double ADLStartValue1 { get; set; }
        public double ADLPeakValue1 { get; set; }
        public double ADLEndValue1 { get; set; }
        public System.DateTime SpikeTime1 { get; set; }
        public double Spike1 { get; set; }
        public System.DateTime SpikeTime2 { get; set; }
        public double Spike2 { get; set; }
        public System.DateTime InsertedDateTime { get; set; }
        public int InsertUserId { get; set; }
    }
}