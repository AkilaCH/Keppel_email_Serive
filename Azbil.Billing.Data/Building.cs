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
    
    public partial class Building : IEntity
    {
        public int BlockId { get; set; }
        public int PlantId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public int InsertedUserId { get; set; }
        public System.DateTime InsertedDateTime { get; set; }
        public string ShortName { get; set; }
        public string AddressLine_1 { get; set; }
        public string AddressLine_2 { get; set; }
        public string AddressLine_3 { get; set; }
        public string AddressLine_4 { get; set; }
    }
}
