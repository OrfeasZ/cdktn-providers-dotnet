using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSecurityPolicyConfig
{
    [JsiiByValue(fqn: "oci.dataSafeSecurityPolicyConfig.DataSafeSecurityPolicyConfigFirewallConfig")]
    public class DataSafeSecurityPolicyConfigFirewallConfig : oci.DataSafeSecurityPolicyConfig.IDataSafeSecurityPolicyConfigFirewallConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#exclude_job DataSafeSecurityPolicyConfigA#exclude_job}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludeJob", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExcludeJob
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#status DataSafeSecurityPolicyConfigA#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_policy_config#violation_log_auto_purge DataSafeSecurityPolicyConfigA#violation_log_auto_purge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "violationLogAutoPurge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ViolationLogAutoPurge
        {
            get;
            set;
        }
    }
}
