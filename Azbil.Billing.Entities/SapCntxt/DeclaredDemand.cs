namespace Azbil.Billing.Entities.SapCntxt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeclaredDemand")]
    public partial class DeclaredDemand
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Building_Code { get; set; }

        [Key]
        [Column(Order = 1)]
        public double Declared_Installation_Load { get; set; }

        [Key]
        [Column(Order = 2)]
        public double Declared_Demand_Load { get; set; }

        [Key]
        [Column(Order = 3)]
        public double Additional_Demand_Load { get; set; }

        [Key]
        [Column(Order = 4)]
        public double Penalty_Demand_Load { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Charge_Interval { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime Start_DateTime { get; set; }
    }
}
