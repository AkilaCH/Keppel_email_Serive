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
    
    public partial class PSummary : IEntity
    {
        public int PSummaryId { get; set; }
        public double NPCYearly { get; set; }
        public double DCC { get; set; }
        public double DDL { get; set; }
        public double DIL { get; set; }
        public double Efficiency { get; set; }
        public double TUR { get; set; }
        public double DF { get; set; }
        public double ECCCMonthly { get; set; }
        public double ECCCCost { get; set; }
        public double NPC { get; set; }
        public double RC { get; set; }
        public double TPC { get; set; }
        public double Other { get; set; }
        public double TC { get; set; }
        public double TUC { get; set; }
        public double ATC { get; set; }
        public Nullable<double> APV { get; set; }
        public Nullable<double> PV { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int UserId { get; set; }
        public System.DateTime InsertedTime { get; set; }
        public string Status { get; set; }
        public int PlantId { get; set; }
    }
}