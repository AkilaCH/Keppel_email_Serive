using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azbil.Billing.Entities.Billing;

namespace Azbil.Billing.Data
{
    public class BillingContext : DbContext
    {
        public BillingContext()
            : base("name=BILLINGDB")
        {
        }
        public BillingContext(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<Azbil.Billing.Entities.Billing.AppDbConfig> AppDbConfigs { get; set; }
        public virtual DbSet<Azbil.Billing.Entities.Billing.ADLTariff> ADLTariffs { get; set; }
        public virtual DbSet<Entities.Billing.CPI> CPIs { get; set; }
        public virtual DbSet<Entities.Billing.Currency> Currencies { get; set; }
        public virtual DbSet<Entities.Billing.CustomerGroup> CustomerGroups { get; set; }
        public virtual DbSet<Entities.Billing.MinOffTakeBase> MinOffTakeBases { get; set; }
        public virtual DbSet<Entities.Billing.SubsidiaryVariableValue> SubsidiaryVariableValues { get; set; }
        public virtual DbSet<Entities.Billing.VariableCondition> VariableConditions { get; set; }
        public virtual DbSet<Entities.Billing.Plant> Plants { get; set; }
        public virtual DbSet<Entities.Billing.Owner> Owners { get; set; }
        public virtual DbSet<Entities.Billing.Building> Buildings { get; set; }
        public virtual DbSet<Entities.Billing.ElectricityType> ElectricityTypes { get; set; }
        public virtual DbSet<Entities.Billing.WaterType> WaterTypes { get; set; }
        public virtual DbSet<Entities.Billing.BillingUnit> BillingUnits { get; set; }
        public virtual DbSet<Entities.Billing.ADLRecord> ADLRecords { get; set; }
        public virtual DbSet<Entities.Billing.MinOffTake> MinOffTakes { get; set; }
        public virtual DbSet<Entities.Billing.MonthlyBillSummaryStatus> MonthlyBillSummaryStatus1 { get; set; }
        public virtual DbSet<Entities.Billing.CSVFieldConfig> CSVFieldConfigs { get; set; }
        public virtual DbSet<Entities.Billing.SAPConfig> SAPConfigs { get; set; }
        public virtual DbSet<Entities.Billing.GeneralRate> GeneralRates { get; set; }
        public virtual DbSet<Entities.Billing.CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<Entities.Billing.FormulaType> FormulaTypes { get; set; }
        public virtual DbSet<Entities.Billing.InvoiceConfig> InvoiceConfigs { get; set; }
        public virtual DbSet<Entities.Billing.FixedDemandCharge> FixedDemandCharges { get; set; }
        public virtual DbSet<Entities.Billing.TariffRecord> TariffRecords { get; set; }
        public virtual DbSet<Entities.Billing.VariableValue> VariableValues { get; set; }
        public virtual DbSet<Entities.Billing.ChangeLog> ChangeLogs { get; set; }
        public virtual DbSet<Entities.Billing.Variable> Variables { get; set; }
        public virtual DbSet<Entities.Billing.GeneralConfig> GeneralConfigs { get; set; }
        public virtual DbSet<Entities.Billing.TariffRecordStatu> TariffRecordStatus { get; set; }
        public virtual DbSet<Entities.Billing.PlantVariable> PlantVariables { get; set; }
        public virtual DbSet<Entities.Billing.WaterRecord> WaterRecords { get; set; }
        public virtual DbSet<Entities.Billing.ElectricRecord> ElectricRecords { get; set; }
        public virtual DbSet<Entities.Billing.PQ> PQs { get; set; }
        public virtual DbSet<Entities.Billing.PQStatusHistory> PQStatusHistories { get; set; }
        public virtual DbSet<Entities.Billing.PQSubsidiaryVariable> PQSubsidiaryVariables { get; set; }
        public virtual DbSet<Entities.Billing.PSummary> PSummaries { get; set; }
        public virtual DbSet<Entities.Billing.MailNotifiConfig> MailNotifiConfigs { get; set; }
        public virtual DbSet<Entities.Billing.MailNotifiMonthlyBillSummary> MailNotifiMonthlyBillSummaries { get; set; }
        public virtual DbSet<Entities.Billing.ReDeclarationDemand> ReDeclarationDemands { get; set; }
        public virtual DbSet<Entities.Billing.BillingUnitFormula> BillingUnitFormulas { get; set; }
        public virtual DbSet<Entities.Billing.PSummaryStatu> PSummaryStatus { get; set; }
        public virtual DbSet<Entities.Billing.QSummaryStatu> QSummaryStatus { get; set; }
        public virtual DbSet<Entities.Billing.QSummary> QSummaries { get; set; }
        public virtual DbSet<Entities.Billing.MonthlyBillSummary> MonthlyBillSummaries { get; set; }
        public virtual DbSet<Entities.Billing.Customer> Customers { get; set; }
        public virtual DbSet<Entities.Billing.Formula> Formulae { get; set; }
        public virtual DbSet<Entities.Billing.BillingUnitConfig> BillingUnitConfigs { get; set; }
        public virtual DbSet<Entities.Billing.MinOffTakeRecordStatu> MinOffTakeRecordStatus { get; set; }
        public virtual DbSet<Entities.Billing.ElectricWaterTariff> ElectricWaterTariffs { get; set; }
        public virtual DbSet<Entities.Billing.QuarterCount> QuarterCounts { get; set; }
        public virtual DbSet<Entities.Billing.MailNotificationHistory> MailNotificationHistories { get; set; }
        public virtual DbSet<Entities.Billing.EmailUser> EmailUsers { get; set; }
    }
}
