using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeDatabaseSecurityConfigManagement
{
    [JsiiByValue(fqn: "oci.dataSafeDatabaseSecurityConfigManagement.DataSafeDatabaseSecurityConfigManagementSqlFirewallConfig")]
    public class DataSafeDatabaseSecurityConfigManagementSqlFirewallConfig : oci.DataSafeDatabaseSecurityConfigManagement.IDataSafeDatabaseSecurityConfigManagementSqlFirewallConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#exclude_job DataSafeDatabaseSecurityConfigManagement#exclude_job}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeJob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExcludeJob
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#status DataSafeDatabaseSecurityConfigManagement#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#violation_log_auto_purge DataSafeDatabaseSecurityConfigManagement#violation_log_auto_purge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "violationLogAutoPurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ViolationLogAutoPurge
        {
            get;
            set;
        }
    }
}
