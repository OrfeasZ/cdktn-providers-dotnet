using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataProtectionBackupPolicyDataLakeStorage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataProtectionBackupPolicyDataLakeStorage.DataProtectionBackupPolicyDataLakeStorageRetentionRule")]
    public class DataProtectionBackupPolicyDataLakeStorageRetentionRule : azurerm.DataProtectionBackupPolicyDataLakeStorage.IDataProtectionBackupPolicyDataLakeStorageRetentionRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_data_lake_storage#duration DataProtectionBackupPolicyDataLakeStorage#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        public string Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_data_lake_storage#name DataProtectionBackupPolicyDataLakeStorage#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_data_lake_storage#absolute_criteria DataProtectionBackupPolicyDataLakeStorage#absolute_criteria}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "absoluteCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AbsoluteCriteria
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_data_lake_storage#days_of_week DataProtectionBackupPolicyDataLakeStorage#days_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DaysOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_data_lake_storage#months_of_year DataProtectionBackupPolicyDataLakeStorage#months_of_year}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monthsOfYear", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MonthsOfYear
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_data_lake_storage#scheduled_backup_times DataProtectionBackupPolicyDataLakeStorage#scheduled_backup_times}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduledBackupTimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ScheduledBackupTimes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/data_protection_backup_policy_data_lake_storage#weeks_of_month DataProtectionBackupPolicyDataLakeStorage#weeks_of_month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeksOfMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? WeeksOfMonth
        {
            get;
            set;
        }
    }
}
