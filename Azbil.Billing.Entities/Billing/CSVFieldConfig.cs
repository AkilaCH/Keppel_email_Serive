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
    
    public partial class CSVFieldConfig : IEntity
    {
        public int CSVFieldConfigId { get; set; }
        public string FieldTextId { get; set; }
        public string FieldDescription { get; set; }
        public int MaxLength { get; set; }
        public int Order { get; set; }
        public string DefaultValue { get; set; }
        public int OmitValue { get; set; }
    }
}
