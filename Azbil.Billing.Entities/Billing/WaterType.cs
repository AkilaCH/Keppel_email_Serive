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
    
    public partial class WaterType : IEntity
    {
        public int WaterTypeId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
