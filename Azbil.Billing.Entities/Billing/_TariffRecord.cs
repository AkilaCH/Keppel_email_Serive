using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public partial class TariffRecord 
    {       
        public Plant Plant { get; set; }        

        public List<ADLTariff> adlTariff { get; set; }

        public BillingUnit billingUnit { get; set; }

        public List<Variable> variableList { get; set; }

        public TariffRecord currentTariffRecord { get; set; }

        public TariffRecord previousQuaterTariffRecord { get; set; }

        public List<PQ> pqValues { get; set; }

        public WaterRecord waterTariff { get; set; }

        public ElectricRecord electricityTariff { get; set; }

        public List<VariableValue> variableValues { get; set; }

        public List<Formula> formulaList { get; set; }

        public List<ADLTariff> adlList { get; set; }

        public List<BillingUnitConfig> billingUnitConstraints { get; set; }

        public DateTime tariffEffectiveFrom { get; set; }

        public Customer Customer { get; set; }

        public Building Block { get; set; }

        public int NValue { get; set; }
    }
}
