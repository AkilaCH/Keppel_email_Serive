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
    
    public partial class QSummary : IEntity
    {
        public int QSummaryId { get; set; }
        public double WA { get; set; }
        public double Efficiency { get; set; }
        public double ET { get; set; }
        public double WT { get; set; }
        public double ECost { get; set; }
        public double WCost { get; set; }
        public double TCost { get; set; }
        public Nullable<double> ATC { get; set; }
        public Nullable<double> AQV { get; set; }
        public Nullable<double> QV { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int UserId { get; set; }
        public System.DateTime InsertedTime { get; set; }
        public string Status { get; set; }
        public int PlantId { get; set; }
        public double AWL { get; set; }
        public double AWC { get; set; }
    }
}