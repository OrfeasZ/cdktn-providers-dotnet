using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeDatabaseSecurityConfigManagement
{
    [JsiiInterface(nativeType: typeof(IDataSafeDatabaseSecurityConfigManagementSqlFirewallConfig), fullyQualifiedName: "oci.dataSafeDatabaseSecurityConfigManagement.DataSafeDatabaseSecurityConfigManagementSqlFirewallConfig")]
    public interface IDataSafeDatabaseSecurityConfigManagementSqlFirewallConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#exclude_job DataSafeDatabaseSecurityConfigManagement#exclude_job}.</summary>
        [JsiiProperty(name: "excludeJob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExcludeJob
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#status DataSafeDatabaseSecurityConfigManagement#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#violation_log_auto_purge DataSafeDatabaseSecurityConfigManagement#violation_log_auto_purge}.</summary>
        [JsiiProperty(name: "violationLogAutoPurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ViolationLogAutoPurge
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeDatabaseSecurityConfigManagementSqlFirewallConfig), fullyQualifiedName: "oci.dataSafeDatabaseSecurityConfigManagement.DataSafeDatabaseSecurityConfigManagementSqlFirewallConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeDatabaseSecurityConfigManagement.IDataSafeDatabaseSecurityConfigManagementSqlFirewallConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#exclude_job DataSafeDatabaseSecurityConfigManagement#exclude_job}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeJob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExcludeJob
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#status DataSafeDatabaseSecurityConfigManagement#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_database_security_config_management#violation_log_auto_purge DataSafeDatabaseSecurityConfigManagement#violation_log_auto_purge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "violationLogAutoPurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ViolationLogAutoPurge
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
