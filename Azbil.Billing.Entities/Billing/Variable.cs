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
    
    public partial class Variable : IEntity
    {
        public string VariableId { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public string Mode { get; set; }
        public string Status { get; set; }
        public int InsertedUserId { get; set; }
        public System.DateTime InsertedDateTime { get; set; }
        public string TextId { get; set; }
        public string TextInfo { get; set; }
    }
}
